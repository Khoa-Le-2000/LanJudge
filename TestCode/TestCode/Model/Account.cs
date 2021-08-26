using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model
{
    public class Account
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Permission { get; set; }

        public Account()
        {
        }

        public Account(int accountID, string userName, string fullName, string permission)
        {
            AccountID = accountID;
            UserName = userName;
            FullName = fullName;
            Permission = permission;
        }
    }
}
