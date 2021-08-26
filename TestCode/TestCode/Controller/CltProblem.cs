using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCode.Model;

namespace TestCode.Controller
{
    class CltProblem
    {
        public List<Problem> GetProblems(int testId)
        {
            byte[] testIdByte = BitConverter.GetBytes(testId);
            byte[] dataSend = new byte[1 + testIdByte.Length];
            dataSend[0] = 2;
            testIdByte.CopyTo(dataSend, 1);
            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFileJson = CltClient.DeserablizeFile(dataReceive);

            List<Problem> problems;
            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                problems = JsonConvert.DeserializeObject<List<Problem>>(json);
            }

            return problems;
        }

        public string getProblemContent(int problemId)
        {
            byte[] problemIdByte = BitConverter.GetBytes(problemId);
            byte[] dataSend = new byte[1 + problemIdByte.Length];
            dataSend[0] = 6;
            problemIdByte.CopyTo(dataSend, 1);
            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFile = CltClient.DeserablizeFile(dataReceive);

            return srcFile;
        }

        private byte[] dataReceive;

        private void WaitResponse()
        {
            while (true)
            {
                if (CltClient.IsDataResponse)
                {
                    dataReceive = CltClient.dataResponse.ToArray();
                    CltClient.IsDataResponse = false;
                    return;
                }
            }
        }
    }
}
