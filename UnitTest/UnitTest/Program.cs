using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = Add(1, 2);
            Console.WriteLine(c);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
