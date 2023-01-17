namespace Constructor
{
    class Student
    {
        int id;
        string Name;
        int classs;
        string division;
        double contact;

        //Constructor
        public Student(int id, string name, int classs, string division, double contact)
        {
            this.id = id;
            Name = name;
            this.classs = classs;
            this.division = division;
            this.contact = contact;
        }
    
    
        static void Main(string[] args)
        {
            //objects
            Student s1 = new Student(01, "abc", 12, "A", 987654321);
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.classs);
            Console.WriteLine(s1.division);
            Console.WriteLine(s1.contact);

        }
    }
}