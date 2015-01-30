using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Test.App
{
    class Program
    {
        private static string test = string.Empty;

        static void Main(string[] args)
        {
            truc machin = new truc();
        }

        public void Method()
        {
            string v = inner.innerVar;
        }

        public class inner
        {
            public static string innerVar = Program.test;
                        public string accessPrivateMember { get { return Program.test; } }
        }
    }

    class truc
    {
        public truc()
        {
            string v = Program.inner.innerVar;
//another dummy comment
            Program.inner inTest = new Program.inner();
            string res = inTest.accessPrivateMember;
        }

    }
}
