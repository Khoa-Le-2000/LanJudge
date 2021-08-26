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
    class CltResult
    {
        public Result GetResult(int accountId, int testId)
        {
            Result result = new Result(accountId, testId);

            byte[] accountIdByte = BitConverter.GetBytes(accountId);
            byte[] testIdByte = BitConverter.GetBytes(testId);

            byte[] dataSend = new byte[9];
            dataSend[0] = 5;
            accountIdByte.CopyTo(dataSend, 1);
            testIdByte.CopyTo(dataSend, 5);

            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFileJson = CltClient.DeserablizeFile(dataReceive);

            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                result.Submissions = JsonConvert.DeserializeObject<List<Submission>>(json);
            }

            return result;
        }

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

        private byte[] dataReceive;
    }
}
