using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model
{
    class Result
    {
        public int AccountId { get; set; }
        public int TestId { get; set; }
        public List<Submission> Submissions { get; set; }

        public Result()
        {
        }

        public Result(int accountId, int testId)
        {
            AccountId = accountId;
            TestId = testId;
        }

        public Result(int accountId, int testId, List<Submission> submissions) : this(accountId, testId)
        {
            Submissions = submissions;
        }
    }
}
