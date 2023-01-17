namespace Method_Overloading
{
    internal class Program
    {
        //Method
        public static void Student()
        {
            Console.WriteLine("Default one");
        }
        //Method Overloading
        public static void Student(int id, string name)
        {

            Console.WriteLine("Your id is {0} ", id);
            Console.WriteLine("Your Name is {0} ",name);
        }
        //method Overloading
        public static void Student(int id, string name, int age)
        {
            Console.WriteLine("Your id is {0}",id);
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your id");
            int id =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name");
            string name =Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age =int.Parse(Console.ReadLine());

            //Directly call by class name because i makes Methods statics
            Program.Student();
            Program.Student(id,name);
            Program.Student(id,name, age);
        }
    }
}