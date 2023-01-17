namespace IENumerable_vs_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();
            years.Add(1995);
            years.Add(1996);
            years.Add(1997);
            years.Add(1998);
            years.Add(1999);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);
            years.Add(2004);
            years.Add(2005);

            /*
            IEnumerable<int> ienum = (IEnumerable<int>)years;

            foreach (int  i in ienum)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("_____________________________");

            IEnumerator<int> ienumrator = years.GetEnumerator();
            while (ienumrator.MoveNext())
            {
                Console.WriteLine(ienumrator.Current.ToString());

            }
            



            */

            //Accesing 2 method with IEnumerator.

            
              
            IEnumerator<int> ienumerator = years.GetEnumerator();
            show1(ienumerator);

            static void show1(IEnumerator<int> i)
            {
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current.ToString());
                    if (Convert.ToInt16(i.Current) > 2001)
                    {
                        show2(i);
                    }
                }
            }

            

            static void show2(IEnumerator<int> i)
            {
                while(i.MoveNext())
                {
                    Console.WriteLine("show2 method" + i.Current.ToString());
                }
            }

            





            //Accessing 2 method with IEnumerable
            //Here it give the beard output because it doesn't know its current cursor
            //start printing from starting in method 2(SHOW2) also.

            /*
            IEnumerable<int> ienum = (IEnumerable<int>)years;
            show1(ienum);

            static void show1(IEnumerable<int>num) 
            {
                foreach (int i in num)
                {
                    Console.WriteLine(i);
                    if (i > 1999)
                    {
                        show2(num);
                    }
                }
            }

            static void show2(IEnumerable<int>num)
            {
                foreach (int i in num)
                {
                    Console.WriteLine("show2 method" + i);
                }
            }

            */

        }
            
    }
}