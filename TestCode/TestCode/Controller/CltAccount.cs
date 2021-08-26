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
    class CltAccount
    {
        public Account CheckLogin(string userName, string password)
        {
            byte[] userNameByte = CltClient.Serialize(userName);
            byte[] passwordByte = CltClient.Serialize(password);
            byte[] userNameLength = BitConverter.GetBytes(userNameByte.Length);
            byte[] passwordLength = BitConverter.GetBytes(passwordByte.Length);

            byte[] dataSend = new byte[1 + userNameByte.Length + passwordByte.Length + userNameLength.Length + passwordLength.Length];

            dataSend[0] = 0;
            userNameLength.CopyTo(dataSend, 1);
            passwordLength.CopyTo(dataSend, 5);
            userNameByte.CopyTo(dataSend, 9);
            passwordByte.CopyTo(dataSend, 9 + userNameByte.Length);

            CltClient.Send(dataSend);
            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            string srcFileJson = CltClient.DeserablizeFile(dataReceive);

            JsonFile jsonFile;
            using (StreamReader reader = new StreamReader(srcFileJson))
            {
                string json = reader.ReadToEnd();
                jsonFile = JsonConvert.DeserializeObject<JsonFile>(json);
            }


            if (jsonFile.Result == 0) return null;
            return jsonFile.Account;
        }

        public int changeFullName(int accountId, string fullName)
        {
            byte[] accountIdByte = BitConverter.GetBytes(accountId);
            byte[] fullNameByte = Encoding.Unicode.GetBytes(fullName);
            byte[] fullNameLenByte = BitConverter.GetBytes(fullNameByte.Length);

            byte[] dataSend = new byte[9 + fullNameByte.Length];
            dataSend[0] = 7;
            accountIdByte.CopyTo(dataSend, 1);
            fullNameLenByte.CopyTo(dataSend, 5);
            fullNameByte.CopyTo(dataSend, 9);

            CltClient.Send(dataSend);
            Thread wait = new Thread(WaitResponse);
            wait.IsBackground = true;
            wait.Start();
            wait.Join();

            return BitConverter.ToInt32(dataReceive, 1);
        }

        public int changePassword(int accountId, string oldPassword, string newPassword)
        {
            byte[] accountIdByte = BitConverter.GetBytes(accountId);
            byte[] oldPasswordByte = Encoding.ASCII.GetBytes(oldPassword);
            byte[] newPasswordByte = Encoding.ASCII.GetBytes(newPassword);
            byte[] oldPasswordLenByte = BitConverter.GetBytes(oldPasswordByte.Length);
            byte[] newPasswordLenByte = BitConverter.GetBytes(newPasswordByte.Length);

            byte[] dataSend = new byte[13 + oldPasswordByte.Length + newPasswordByte.Length];
            dataSend[0] = 8;
            accountIdByte.CopyTo(dataSend, 1);
            oldPasswordLenByte.CopyTo(dataSend, 5);
            newPasswordLenByte.CopyTo(dataSend, 9);
            oldPasswordByte.CopyTo(dataSend, 13);
            newPasswordByte.CopyTo(dataSend, 13 + oldPassword.Length);

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

        private class JsonFile
        {
            public int Result;
            public Account Account;
        }
    }
}
