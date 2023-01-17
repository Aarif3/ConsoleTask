namespace Constructor_Overloading
{
    internal class Student
    {
        //default Constructor
        public Student() 
        {
            Console.WriteLine("Default Constructor invoke");
        }
        
        //Constructor overloaded
        public Student(string name)
        {
            Console.WriteLine("Your Name is{0}", name);
        }

        //constructor overloaded
        public Student(int id, string name, string standard)
        {
            Console.WriteLine("your id is{0} ", id);
            Console.WriteLine("your name is{0} ", name);
            Console.WriteLine("your standard is{0} ", standard);
        }

        static void Main(string[] args)
        {
            Student obj =new Student();

            Student obj1 = new Student("abc");

            Student obj2 = new Student(10,"xyz","10");
        }

    }
}