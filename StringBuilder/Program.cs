using System.Text;
using System;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello");
            sb.AppendLine("World");
            sb.Append("hii");
            Console.WriteLine(sb);
            sb.AppendJoin("hello","hello");
            Console.WriteLine(sb);
        }
    }
}