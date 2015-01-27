using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Test.App
{
    class Program
    {
        private static string test;

        static void Main(string[] args)
        {

        }

        public void Method()
        {
            string v = inner.innerVar;
        }

        public class inner
        {
            public static string innerVar = Program.test;

        }
    }

    class truc
    {
        public truc()
        {
            string v = Program.inner.innerVar;

        }

    }
}
