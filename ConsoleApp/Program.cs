using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please add first number");

            int num1;


            while(true)
            {
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("You should be add int numbers");
                }  
            }

                Console.WriteLine("Please add secondy number");

                int num2 = int.Parse(Console.ReadLine());

                int num = Sum(num1,num2);

                Console.WriteLine("Sum : " + num);

                 Console.ReadLine();



        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
