using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCode.Model;

namespace TestCode.Controller
{
    class CltSubmission
    {
        public object Submission { get; private set; }

        public Submission submit(string srcFile, int accountId, int problemId)
        {
            if (!File.Exists(srcFile)) return null;

            Submission submission = new Submission();
            byte[] accountIdByte = BitConverter.GetBytes(accountId);
            byte[] problemIdByte = BitConverter.GetBytes(problemId);

            byte[] dataSend = new byte[9];
            dataSend[0] = 3;
            accountIdByte.CopyTo(dataSend, 1);
            problemIdByte.CopyTo(dataSend, 5);

            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            byte[] submissionId = new byte[dataReceive.Length - 1];
            Buffer.BlockCopy(dataReceive, 1, submissionId, 0, dataReceive.Length - 1);
            submission.SubmissonId = BitConverter.ToInt64(submissionId, 0);

            byte[] dataFile = CltClient.SerializeFile(srcFile);
            byte[] dataSendFile = new byte[1 + 8 + dataFile.Length];
            dataSendFile[0] = 4;
            BitConverter.GetBytes(submission.SubmissonId).CopyTo(dataSendFile, 1);
            dataFile.CopyTo(dataSendFile, 9);

            CltClient.Send(dataSendFile);

            wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFileJson = CltClient.DeserablizeFile(dataReceive);

            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                submission = JsonConvert.DeserializeObject<Submission>(json);
            }

            return submission;
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