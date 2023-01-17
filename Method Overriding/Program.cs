namespace Method_Overriding
{
    class parent
    {
        public virtual void Show(int id)
        {
            Console.WriteLine("Your id is {0}",id);
        }
    }

    class child : parent
    {
        public override void Show(int age)
        {
            Console.WriteLine("Your age is{0}",age);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter id or age");
            int val = int.Parse(Console.ReadLine());

            parent c1 = new parent();
            c1.Show(val);
        }
    }
}