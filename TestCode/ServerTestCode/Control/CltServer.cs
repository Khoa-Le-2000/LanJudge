using Newtonsoft.Json;
using ServerTestCode.Model;
using ServerTestCode.View.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTestCode.Control
{
    class CltServer
    {
        private static List<Socket> ClientList;
        private static Socket server;
        private static IPEndPoint IP;
        private string serverIP = "192.168.145.100";
        private int PORT = 9999;

        public void Connect()
        {
            Console.WriteLine("Server setting up ...");
            ClientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        Console.WriteLine($"{client.RemoteEndPoint.ToString()}: connected");

                        Thread recive = new Thread(Recive);
                        recive.IsBackground = true;
                        recive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, PORT);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
            Console.WriteLine("Server started");
        }

        public void Close()
        {
            Console.WriteLine("Server stopping...");
            server.Close();
            Console.WriteLine("Server stopped");
        }

        // Data revive: 0|length UserName|length Password|UserName|Password
        private void ReciveRequestLogiIn(Socket client, byte[] data)
        {
            int lenUserName = BitConverter.ToInt32(data,1);
            int lenPassword = BitConverter.ToInt32(data,5);
            byte[] byteUserName = new byte[lenUserName];
            byte[] bytePassword = new byte[lenPassword];
            Buffer.BlockCopy(data, 9, byteUserName, 0, lenUserName);
            Buffer.BlockCopy(data, 9 + lenUserName, bytePassword, 0, lenPassword);

            string userName = (string)Deserialize(byteUserName);
            string password = (string)Deserialize(bytePassword);

            CltAccount cltAccount = new CltAccount();
            string fileResult = cltAccount.checkLogin(userName, password);

            SendFile(client, fileResult);
        }

        // Data revive: 1
        private void ReciverRequestListContest(Socket client)
        {
            CltTest cltTest = new CltTest();
            string srcFile = cltTest.getResponseListTest();
            SendFile(client, srcFile);
        }

        // Data revive: 2|TestId
        private void ReciveRequestListProblem(Socket client, byte[] data)
        {
            int testId = BitConverter.ToInt32(data, 1);
            CltProblem cltProblem = new CltProblem();
            string srcFile = cltProblem.getProblemListRequest(testId);
            SendFile(client, srcFile);
        }

        // Data recive: 3|AccountID|ProblemID
        private void ReciveRequestSubmission(Socket client, byte[] data)
        {
            int accountId = BitConverter.ToInt32(data, 1);
            int problemId = BitConverter.ToInt32(data, 5);
            CltSubmission cltSubmission = new CltSubmission();
            long submissionId = cltSubmission.createSubmission(accountId, problemId);

            byte[] submissionIdByte = BitConverter.GetBytes(submissionId);
            byte[] dataSend = new byte[1 + submissionIdByte.Length];
            dataSend[0] = 1;
            submissionIdByte.CopyTo(dataSend, 1);

            client.Send(dataSend);
        }

        // Data recive: 4|submission ID|file name length|file name|file data length|file data
        private void ReciveFileCode(Socket client, byte[] data)
        {
            long submissionId = BitConverter.ToInt64(data, 1);
            int fileNameLen = BitConverter.ToInt32(data, 9);
            string fileName = Encoding.ASCII.GetString(data, 13, fileNameLen);
            int fileDataLen = BitConverter.ToInt32(data, 13 + fileNameLen);
            string fileSrc = $"D:\\Server\\Submission\\{fileName}";

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileSrc, FileMode.Create));
            binaryWriter.Write(data, 13 + fileNameLen + 4, fileDataLen);
            binaryWriter.Close();

            Console.WriteLine($"{client.RemoteEndPoint}: server marking file...");
            CltSubmission cltSubmission = new CltSubmission();
            Submission submission = cltSubmission.Marking(submissionId, fileSrc);
            cltSubmission.updateSubmission(submission);
            Console.WriteLine($"{client.RemoteEndPoint}: server marked file");

            string srcFile = @"D:\Server\" + DateTime.Now.ToString("MMddhhmmssffff") + ".json";
            using (StreamWriter writer = File.CreateText(srcFile))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, submission);
            }
            SendFile(client, srcFile);
        }

        // Data recive: 5|Account ID|Test ID
        private void ReciveRequestResult(Socket client, byte[] data)
        {
            int accountId = BitConverter.ToInt32(data, 1);
            int testId = BitConverter.ToInt32(data, 5);
            CltSubmission cltSubmission = new CltSubmission();
            SendFile(client, cltSubmission.getRequestListSubmission(accountId, testId));
        }

        // Data recive: 6|Problem Id
        private void ReciveRequestContentProblem(Socket client, byte[] data)
        {
            int problemId = BitConverter.ToInt32(data, 1);
            CltProblem cltProblem = new CltProblem();
            SendFile(client, cltProblem.getProblemContent(problemId));
        }

        // Data recive: 7|Account Id|Length full name|Full Name
        private void ReciveRequestChangeFullName(Socket client, byte[] data)
        {
            int accountId = BitConverter.ToInt32(data, 1);
            int lenFullName = BitConverter.ToInt32(data, 5);
            string fullName = Encoding.Unicode.GetString(data, 9, lenFullName);

            CltAccount cltAccount = new CltAccount();
            int res = cltAccount.ChangeFullName(accountId, fullName);

            byte[] dataSend = new byte[5];
            dataSend[0] = 1;
            BitConverter.GetBytes(res).CopyTo(dataSend, 1);
            client.Send(dataSend);
        }

        // Data recive: 8|Account Id|length old password|length new password|old password|new passworld
        private void ReciveRequestChangePassword(Socket client, byte[] data)
        {
            int accountId = BitConverter.ToInt32(data, 1);
            int lenOldPass = BitConverter.ToInt32(data, 5);
            int lenNewPass = BitConverter.ToInt32(data, 9);
            string oldPass = Encoding.ASCII.GetString(data, 13, lenOldPass);
            string newPass = Encoding.ASCII.GetString(data, 13 + lenOldPass, lenNewPass);

            CltAccount cltAccount = new CltAccount();
            int res = cltAccount.ChangePass(accountId, oldPass, newPass);

            byte[] dataSend = new byte[5];
            dataSend[0] = 1;
            BitConverter.GetBytes(res).CopyTo(dataSend, 1);
            client.Send(dataSend);
        }

        // Data recive: 100|file name length|file name|file data length|file data
        private void ReciveRequestAddContest(Socket client, byte[] data)
        {
            int fileNameLen = BitConverter.ToInt32(data, 1);
            string fileName = Encoding.ASCII.GetString(data, 5, fileNameLen);
            int fileDataLen = BitConverter.ToInt32(data, 5 + fileNameLen);
            string fileSrc = $"D:\\Server\\Contest\\{fileName}";

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileSrc, FileMode.Create));
            binaryWriter.Write(data, 9 + fileNameLen, fileDataLen);
            binaryWriter.Close();

            Test test;
            using (StreamReader reader = new StreamReader(fileSrc))
            {
                string json = reader.ReadToEnd();
                test = JsonConvert.DeserializeObject<Test>(json);
            }

            CltTest cltTest = new CltTest();
            test.TestId = cltTest.addTest(test.TestName,test.TimeTest,test.TimeStart);

            byte[] testIdByte = BitConverter.GetBytes(test.TestId);
            byte[] dataSend = new byte[1 + testIdByte.Length];
            dataSend[0] = 1;
            testIdByte.CopyTo(dataSend, 1);

            client.Send(dataSend);
        }

        // Data recive: 101|file name length|file name|file data length|file data
        private void ReciveRequestUploadContest(Socket client, byte[] data)
        {
            int fileNameLen = BitConverter.ToInt32(data, 1);
            string fileName = Encoding.ASCII.GetString(data, 5, fileNameLen);
            int fileDataLen = BitConverter.ToInt32(data, 5 + fileNameLen);
            string fileSrc = $"D:\\Server\\Contest\\{fileName}";

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileSrc, FileMode.Create));
            binaryWriter.Write(data, 5 + fileNameLen + 4, fileDataLen);
            binaryWriter.Close();

            CltTest cltTest = new CltTest();
            int result = cltTest.relaseTest(fileSrc);

            byte[] dataSend = new byte[5];
            dataSend[0] = 1;
            BitConverter.GetBytes(result).CopyTo(dataSend, 1);
            client.Send(dataSend);
        }

        // Data recive: 102|test Id
        private void ReciveRequestDeleteTest(Socket client, byte[] data)
        {
            int testId = BitConverter.ToInt32(data, 1);

            CltTest cltTest = new CltTest();
            int result = cltTest.deleteTest(testId);

            byte[] dataSend = new byte[5];
            dataSend[0] = 1;
            BitConverter.GetBytes(result).CopyTo(dataSend, 1);
            client.Send(dataSend);
        }

        // Data recive: 103|file name length|file name|file data length|file data
        private void ReciveRequestEditTest(Socket client, byte[] data)
        {
            int fileNameLen = BitConverter.ToInt32(data, 1);
            string fileName = Encoding.ASCII.GetString(data, 5, fileNameLen);
            int fileDataLen = BitConverter.ToInt32(data, 5 + fileNameLen);
            string fileSrc = $"D:\\Server\\{fileName}";

            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileSrc, FileMode.Create));
            binaryWriter.Write(data, 5 + fileNameLen + 4, fileDataLen);
            binaryWriter.Close();

            Test test;
            using (StreamReader reader = new StreamReader(fileSrc))
            {
                string json = reader.ReadToEnd();
                test = JsonConvert.DeserializeObject<Test>(json);
            }

            CltTest cltTest = new CltTest();
            int result = cltTest.updateTest(test.TestId, test.TestName, test.TimeTest, test.TimeStart);

            byte[] dataSend = new byte[5];
            dataSend[0] = 1;
            BitConverter.GetBytes(result).CopyTo(dataSend, 1);
            client.Send(dataSend);
        }

        public void Recive(object obj)
        {
            Socket client = obj as Socket;
            /*
             * //////////////////////////////////
             * Rules for first byte             /
             * 0: request log in                /
             * 1: request list contest          /
             * 2: request list problem          /
             * 3: request submission            /
             * 4: submmit file code             /
             * 5: request list submission       /
             * 6: request content problem       /
             * 7: request change full name      /
             * 8: request change password       /
             * //////////////////////////////////
             * 100: Teacher request add contest /
             * 101: Teacher upload contest      /
             * 102: Teacher request delete test /
             * 103: Teacher request edit test   /
             * //////////////////////////////////
             */

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int lenData = client.Receive(data);

                    switch (data[0])
                    {
                        case 0:
                            Console.WriteLine($"{client.RemoteEndPoint}: request login");
                            ReciveRequestLogiIn(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse login");
                            break;

                        case 1:
                            Console.WriteLine($"{client.RemoteEndPoint}: request list contest");
                            ReciverRequestListContest(client);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse request list contest");
                            break;

                        case 2:
                            Console.WriteLine($"{client.RemoteEndPoint}: request list problem");
                            ReciveRequestListProblem(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse request list problem");
                            break;

                        case 3:
                            Console.WriteLine($"{client.RemoteEndPoint}: request submission");
                            ReciveRequestSubmission(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse submission ID");
                            break;

                        case 4:
                            Console.WriteLine($"{client.RemoteEndPoint}: request submit file");
                            ReciveFileCode(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse result");
                            break;

                        case 5:
                            Console.WriteLine($"{client.RemoteEndPoint}: request list submission");
                            ReciveRequestResult(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse result");
                            break;

                        case 6:
                            Console.WriteLine($"{client.RemoteEndPoint}: request content problem");
                            ReciveRequestContentProblem(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse content problem");
                            break;

                        case 7:
                            Console.WriteLine($"{client.RemoteEndPoint}: request change full name");
                            ReciveRequestChangeFullName(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse change full name");
                            break;

                        case 8:
                            Console.WriteLine($"{client.RemoteEndPoint}: request change password");
                            ReciveRequestChangePassword(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse change password");
                            break;

                        case 100:
                            Console.WriteLine($"{client.RemoteEndPoint}: Teacher request add contest");
                            ReciveRequestAddContest(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse add contest");
                            break;

                        case 101:
                            Console.WriteLine($"{client.RemoteEndPoint}: Teacher upload contest");
                            ReciveRequestUploadContest(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse upload contest");
                            break;

                        case 102:
                            Console.WriteLine($"{client.RemoteEndPoint}: Teacher request delete test");
                            ReciveRequestDeleteTest(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse delete test");
                            break;

                        case 103:
                            Console.WriteLine($"{client.RemoteEndPoint}: Teacher request edit test");
                            ReciveRequestEditTest(client, data);
                            Console.WriteLine($"{client.RemoteEndPoint}: server reponse edit test");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{client.RemoteEndPoint.ToString()}: disconnect! because {e.Message}");
                ClientList.Remove(client);
                client.Close();
            }
        }

        public void SendFile(Socket Client, string srcFile)
        {
            byte[] fileNameByte = Encoding.ASCII.GetBytes(Path.GetFileName(srcFile));
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            byte[] fileData = File.ReadAllBytes(srcFile);
            byte[] fileDataLen = BitConverter.GetBytes(fileData.Length);

            byte[] dataSend = new byte[1 + fileNameLen.Length + fileNameByte.Length + fileDataLen.Length + fileData.Length];
            dataSend[0] = 1;
            fileNameLen.CopyTo(dataSend, 1);
            fileNameByte.CopyTo(dataSend, 1 + fileNameLen.Length);
            fileDataLen.CopyTo(dataSend, 1 + fileNameLen.Length + fileNameByte.Length);
            fileData.CopyTo(dataSend, 1 + fileNameLen.Length + fileNameByte.Length + fileDataLen.Length);

            Client.Send(dataSend);
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}
