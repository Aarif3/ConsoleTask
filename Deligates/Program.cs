namespace Deligates
{
    //public delegate void Calculation(int a);
    //class Program
    //{

        
    //    }
        /*public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("addition is {0}", result); ;
        }

        public static void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is {0}", result);
        }

        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is {0}",result);
        }


        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Devision is {0}", result);
        }*/
    }



//Lambda 
    internal class Programs
    {
    public delegate void Calculation(int a);
    static void Main(string[] args)
        {
            Calculation obj = (a) =>
            {
                a *= 5;
                Console.WriteLine(a);
            };

            obj.Invoke(5);
        Console.WriteLine();
//Lambda ends///

            //Calculation obj = new Calculation(Program.division);
            //obj(2, 3);
            //Calculation obj1 = new Calculation(Program.addition);
            //obj1(2, 5);
            //obj = new Calculation(Program.subtraction);
            //obj(2, 0);
            //obj += add;
            //obj(2, 5);
            //Calculation obj1 = new Calculation(Program.sub);
            //obj1(2, 5);
            //Calculation obj2 = new Calculation(Program.div);
            //obj2(2, 5);
            //Calculation obj3 = new Calculation(Program.div);
            //obj3(2, 5);
        }
    }
