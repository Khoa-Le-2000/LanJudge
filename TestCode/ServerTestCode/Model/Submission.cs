using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Model
{
    class Submission
    {
        public long SubmissonId { get; set; }
        public int AccountID { get; set; }
        public int ProblemID { get; set; }
        public string ProblemName { get; set; }
        public string Result { get; set; }
        public string TimeRun { get; set; }
        public DateTime TimeSubmit { get; set; }
        public int NumOfTestCase { get; set; }

        public Submission(long submissonId)
        {
            SubmissonId = submissonId;
        }

        public Submission(long submissonId, int accountID, int problemID, string problemName, string result, string timeRun, DateTime timeSubmit, int numOfTestCase) : this(submissonId)
        {
            AccountID = accountID;
            ProblemID = problemID;
            ProblemName = problemName;
            Result = result;
            TimeRun = timeRun;
            TimeSubmit = timeSubmit;
            NumOfTestCase = numOfTestCase;
        }

        public Submission()
        {
        }
    }
}
