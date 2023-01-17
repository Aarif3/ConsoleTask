using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALUE_REF_OUT_Keyword
{
    internal class Program
    {
        /*
        public static void PassByRef(ref int a)
        {
            a = a + 5;
            Console.WriteLine("value is {0}",a);
        }


        static void Main(string[] args)
        {
            int value = 5;
            PassByRef(ref value);
            Console.WriteLine(value);
            Console.ReadLine();
        }
        */

        public static void PassByOut(out int c)
        {
            c = 5;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            int value = 10; // this value will change to 5....
            PassByOut(out value);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
