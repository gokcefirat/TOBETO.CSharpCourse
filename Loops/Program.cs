using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            


            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {

                    result = false;
                    i = number;
                }
            }
             return result;
        }



        public static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            //for (int i = 100; i<=0; i=i-2) Yüzden geriye 2 eksilerek sayma

            Console.WriteLine("Finished!");
        }

        public static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        public static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        public static void ForeachLoop()
        {
            string[] students = new string[] { "Engin, Derin, Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
             
    }

}
