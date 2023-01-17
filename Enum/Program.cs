using System;
namespace Enums
{
    enum days
    {

        monday,  //0                //default value to enum is started from 0
        Tuesday, //1
        Wednesday,  //2                     \\We can also set the value 
        
        Thursday,  //3                         eg.  Wednesday = 5, then wednesday value will be 5 and it will increase by 1
                                       //eg. thursday value will be 6 friday will be 7 and so on....
        Friday,   //4
        Saturday,  //5
        Sunday   //6
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // printing Days
            string[] members = (string[]) Enum.GetNames(typeof(days));
                
                //Console.WriteLine(members);

            foreach (string member in members)
            {
                Console.WriteLine(member);
            }


            // printing Values of that Days....
            int[] values = (int[]) Enum.GetValues(typeof(days));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }



            Console.ReadLine();
            //printing days one by one by giving value......
            //days myday = (days)1;
            //Console.WriteLine(myday);
            //Console.ReadLine();

           // Console.WriteLine(days.Friday);
        }
    }
}