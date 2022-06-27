using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Please Choose an option");
            Console.WriteLine("1.Even check");
            Console.WriteLine("2.Odd check");
            Console.WriteLine("0.Exit");
            int ans = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            do {

                if (ans == 1)
                {
                    checker();
                    Console.WriteLine("Press 0 to exit");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                else if (ans == 2)
                {
                    checker();
                    Console.WriteLine("Press 0 to exit");
                    ans = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    stop = true;
                    Console.WriteLine("Thank you! goodbye");
                }
            } while (!stop); 
     void checker()
            {
                Console.WriteLine("Please enter number to be checked");
                int c_ans = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (c_ans % 2 == 0)
                {
                    Console.WriteLine("The number is even");

                }
                else
                {
                    Console.WriteLine("The number is odd");

                }

            }


        }
    }
}
 