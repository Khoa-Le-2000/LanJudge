using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Model
{
    class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int TimeTest { get; set; }
        public DateTime TimeStart { get; set; }
        public List<Problem> Problems { get; set; }

        public Test(string testName, int timeTest)
        {
            TestName = testName;
            TimeTest = timeTest;
        }

        public Test(string testName, int timeTest, List<Problem> problems) : this(testName, timeTest)
        {
            Problems = problems;
        }

        public Test()
        {
        }

        public Test(int testId, string testName, int timeTest, DateTime timeStart, List<Problem> problems)
        {
            TestId = testId;
            TestName = testName;
            TimeTest = timeTest;
            TimeStart = timeStart;
            Problems = problems;
        }
    }
}
