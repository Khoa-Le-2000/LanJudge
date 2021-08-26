using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.Model
{
    class TestCase
    {
        public int TestCaseId { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public TestCase(string input, string output)
        {
            Input = input;
            Output = output;
        }

        public TestCase(int testCaseId, string input, string output)
        {
            TestCaseId = testCaseId;
            Input = input;
            Output = output;
        }

        public TestCase()
        {
        }
    }
}
