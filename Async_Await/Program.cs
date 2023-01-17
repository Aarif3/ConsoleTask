using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{



    internal class Program
    {

        public static async void task1()
        {
            await Task.Run(()=>
                {
                    Console.WriteLine("TAsk1 is starting....");
                    Thread.Sleep(3000);
                    Console.WriteLine("Task1 is completed...");
                });
        }


        public static async void task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TAsk2 is starting....");
                Thread.Sleep(1000);
                Console.WriteLine("Task2 is completed...");
            });
        }

        public static async void task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TAsk3 is starting....");
                Thread.Sleep(6000);
                Console.WriteLine("Task1 is completed...");
            });
        }

        public static async void task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TAsk4 is starting....");
                Thread.Sleep(2000);
                Console.WriteLine("Task4 is completed...");
            });
        }



        static void Main(string[] args)
        {
            task1();
            task2();
                
            task3();
            task4();


            //wrong while calling the methods.
        }
    }
}
