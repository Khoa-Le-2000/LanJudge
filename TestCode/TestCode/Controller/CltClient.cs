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

namespace TestCode.Controller
{
    static class CltClient
    {
        private static IPEndPoint IP;
        private static Socket client;
        private static string IpServer = "192.168.145.100";
        private static int PORT = 9999;
        public static bool IsDataResponse = false;
        public static byte[] dataResponse;

        private static Thread listen;

        public static bool Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse(IpServer), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                return false;
            }

            listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

            return true;
        }

        public static void Close()
        {
            client.Close();
        }

        public static void Send(byte[] data)
        {
            client.Send(data);
        }

        public static string DeserablizeFile(byte[] data)
        {
            int fileNameLen = BitConverter.ToInt32(data, 1);
            string fileName = Encoding.ASCII.GetString(data, 5, fileNameLen);
            int dataContentLen = BitConverter.ToInt32(data, 5 + fileNameLen);

            byte[] dataContent = new byte[dataContentLen];
            string srcFile = $"C:\\TestCode\\{fileName}";
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(srcFile, FileMode.Create));
            binaryWriter.Write(data, 5 + fileNameLen+4, dataContentLen);
            binaryWriter.Close();

            return srcFile;
        }

        public static void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    if (data[0] == 1)
                    {
                        if (dataResponse != null)
                            Array.Clear(dataResponse, 0, dataResponse.Length);
                        dataResponse = data.ToArray();
                        IsDataResponse = true;
                    }
                }
            }
            catch
            {
                Close();
            }
        }

        public static byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        public static byte[] SerializeFile(string srcFile)
        {
            string fileName = DateTime.Now.ToString("MMddhhmmssffff") + Path.GetExtension(srcFile);
            byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
            byte[] fileData = File.ReadAllBytes(srcFile);
            byte[] fileDataLen = BitConverter.GetBytes(fileData.Length);

            byte[] dataSend = new byte[fileNameLen.Length + fileNameByte.Length + fileDataLen.Length + fileData.Length];
            fileNameLen.CopyTo(dataSend, 0);
            fileNameByte.CopyTo(dataSend, fileNameLen.Length);
            fileDataLen.CopyTo(dataSend, fileNameLen.Length + fileNameByte.Length);
            fileData.CopyTo(dataSend, fileNameLen.Length + fileNameByte.Length + fileDataLen.Length);

            return dataSend;
        }

        public static object Deserablize(byte[] data)
        {
            byte[] dataRecive = new byte[data.Length - 1];
            Buffer.BlockCopy(data, 1, dataRecive, 0, dataRecive.Length);
            MemoryStream stream = new MemoryStream(dataRecive);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
    }
}
