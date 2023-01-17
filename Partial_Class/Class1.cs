using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public partial class Student
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1._id = 10;
            s1.Name = "abcd";
            Console.WriteLine(s1._name);
            Console.WriteLine(s1._id);
        }
    }
}
