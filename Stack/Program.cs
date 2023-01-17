using System.Collections;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s1= new Stack();
            s1.Push("Abc");
            s1.Push(1);
            s1.Push(2.22);
            s1.Push('a');
            //Item Puched
            
            //pop 
            s1.Pop();

            s1.Peek();

            
            s1.Contains("abc");
            
            s1.Clear();
            foreach (object i in s1)
            {
                Console.WriteLine(i);
            }
        }
    }
}