using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using Newtonsoft.Json;
using TestCode.Model;
using System.Threading;

namespace TestCode.Controller
{
    class CltTest
    {
       //public static Account Account = new Account();

        public List<Test> loadTest()
        {
            byte[] data = new byte[1];
            data[0] = 1;
            CltClient.Send(data);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFileJson = CltClient.DeserablizeFile(dataReceive);

            List<Test> tests;
            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                tests = JsonConvert.DeserializeObject<List<Test>>(json);
            }

            return tests;
        }

        public int deleteTest(int testId)
        {
            byte[] data = new byte[5];
            data[0] = 102;
            BitConverter.GetBytes(testId).CopyTo(data, 1);
            CltClient.Send(data);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            return BitConverter.ToInt32(dataReceive, 1);
        }

        public int editTest(Test test)
        {
            string srcFile = $"C:\\TestCode\\{DateTime.Now.ToString("MMddhhmmssffff")}.json";

            using (StreamWriter writer = File.CreateText(srcFile))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, test);
            }

            byte[] dataFile = CltClient.SerializeFile(srcFile);
            byte[] dataSendFile = new byte[1 + dataFile.Length];
            dataSendFile[0] = 103;
            dataFile.CopyTo(dataSendFile, 1);

            CltClient.Send(dataSendFile);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            return BitConverter.ToInt32(dataReceive, 1);
        }

        public int addTest(string srcFile)
        {
            byte[] fileNameByte = Encoding.ASCII.GetBytes(Path.GetFileName(srcFile));
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            byte[] fileData = File.ReadAllBytes(srcFile);
            byte[] fileDataLen = BitConverter.GetBytes(fileData.Length);

            byte[] dataFile = new byte[fileNameLen.Length + fileNameByte.Length + fileDataLen.Length + fileData.Length];
            fileNameLen.CopyTo(dataFile, 0);
            fileNameByte.CopyTo(dataFile, fileNameLen.Length);
            fileDataLen.CopyTo(dataFile, fileNameLen.Length + fileNameByte.Length);
            fileData.CopyTo(dataFile, fileNameLen.Length + fileNameByte.Length + fileDataLen.Length);

            byte[] dataSend = new byte[dataFile.Length + 1];
            dataSend[0] = 101;
            dataFile.CopyTo(dataSend, 1);

            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            return BitConverter.ToInt32(dataReceive, 1);
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
        
        public string createTest(int testId, List<Problem> problems)
        {
            JsonFile jsonFile = new JsonFile();
            jsonFile.testId = testId;

            string destinationFile = $"C:\\TestCode\\{DateTime.Now.ToString("MMddhhmmssffff")}.zip";

            string destinationFolder = Path.GetDirectoryName(destinationFile) + "\\" + Path.GetFileNameWithoutExtension(destinationFile);

            Directory.CreateDirectory(destinationFolder);

            foreach (Problem problem in problems)
            {
                File.Copy(problem.Content, $"{destinationFolder}\\{Path.GetFileName(problem.Content)}", true);
                foreach(TestCase testCase in problem.testCase)
                {
                    if (testCase.Input != null)
                    {
                        copyDirectory(testCase.Input, destinationFolder);
                    }
                    copyDirectory(testCase.Output, destinationFolder);
                }
                problem.Content = $"\\{Path.GetFileName(problem.Content)}";

                string input = problem.testCase[0].Input;
                string output = problem.testCase[0].Output;
                problem.testCase = GetTestCasess(input, output);
            }

            jsonFile.problems = problems;

            string directoryFileJson = $"{destinationFolder}\\{Path.GetFileNameWithoutExtension(destinationFile)}.json";

            using (StreamWriter file = File.CreateText(directoryFileJson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(file, jsonFile);
            }

            ZipFile.CreateFromDirectory(destinationFolder, destinationFile);
            //Directory.Delete(destinationFolder, true);

            return destinationFile;
        }

        private List<TestCase> GetTestCasess(string input, string output)
        {
            List<TestCase> testCases = new List<TestCase>();

            string[] tokens = output.Split('\\');
            string folderOutput = '\\' + tokens[tokens.Length - 1] + '\\';
            string folderInput = "";

            if (input != null) {
                tokens = input.Split('\\');
                folderInput = '\\' + tokens[tokens.Length - 1] + '\\';
            }

            foreach (string file in Directory.EnumerateFiles(output))
            {
                TestCase testCase = new TestCase();
                
                string fileName = Path.GetFileName(file);
                string fileNameNoEx = Path.GetFileNameWithoutExtension(file);
                testCase.Output = folderOutput + fileName;

                if (input != null) {
                    foreach (string fileIn in Directory.EnumerateFiles(input))
                    {
                        if (Path.GetFileNameWithoutExtension(fileIn) == fileNameNoEx)
                        {
                            testCase.Input = folderInput + Path.GetFileName(fileIn);
                            break;
                        }
                    }
                }
                else
                {
                    testCase.Input = null;
                }
                testCases.Add(testCase);
            }
            return testCases;
        }

        //1 sucessful
        private int copyDirectory(string sourceFolder, string destinationFoler)
        {
            Console.WriteLine(Directory.Exists(sourceFolder));
            Console.WriteLine(sourceFolder);

            string[] directorys = sourceFolder.Split(Path.DirectorySeparatorChar);
            string folderName = directorys[directorys.Length - 1];

            destinationFoler += "\\" + folderName;

            Directory.CreateDirectory(destinationFoler);

            foreach (string file in Directory.EnumerateFiles(sourceFolder))
            {
                Console.WriteLine(file);
                string fileName = Path.GetFileName(file);
                Console.WriteLine(fileName);
                File.Copy(file, $"{destinationFoler}\\{fileName}", true);
            }

            return 1;
        }

        public int requestTestId(Test test)
        {
            string srcFileRequest = $"C:\\TestCode\\{DateTime.Now.ToString("MMddhhmmssffff")}.json";
            using (StreamWriter writer = File.CreateText(srcFileRequest))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(writer, test);
            }

            byte[] dataFile = CltClient.SerializeFile(srcFileRequest);
            byte[] dataSend = new byte[1 + dataFile.Length];
            dataSend[0] = 100;
            dataFile.CopyTo(dataSend, 1);

            CltClient.Send(dataSend);

            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            return BitConverter.ToInt32(dataReceive, 1);
        }
        
        private class JsonFile
        {
            public int testId;
            public List<Problem> problems;
        }
    }
}