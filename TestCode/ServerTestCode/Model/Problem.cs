using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Model
{
    class Problem
    {
        public int ProblemId { get; set; }
        public string ProblemName { get; set; }
        public string Content { get; set; }
        public List<TestCase> testCase { get; set; }

        public Problem(string problemName, string content)
        {
            ProblemName = problemName;
            Content = content;
        }

        public Problem(string problemName, string content, List<TestCase> testCase) : this(problemName, content)
        {
            this.testCase = testCase;
        }

        public Problem(int problemId, string problemName, string content, List<TestCase> testCase)
        {
            ProblemId = problemId;
            ProblemName = problemName;
            Content = content;
            this.testCase = testCase;
        }

        public Problem()
        {
        }
    }
}
