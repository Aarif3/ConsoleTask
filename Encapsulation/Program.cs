namespace Encapsulation
{
    public class student
    {
        public int id;
        public string name;

        public void setName(string name,int id)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is required");
            }
            else
            {


                this.name = name;
                this.id = id;
            }
        }

        public void getName()
        {
            if(this.name == null)
            {

            }
            else {
                Console.WriteLine("Id is ", +this.id);
                Console.WriteLine("Name is {0}", this.name);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.setName("abcd",123);
            

        }
    }
}