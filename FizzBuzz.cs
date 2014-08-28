using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 35; i = i + 1)
            {
                FizzBuzz(i);
            }
            {
                Console.ReadKey();
            }
        }
        
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 5 != 0 && number % 3 != 0)
            {
                Console.WriteLine(number);
            }
           
        }
       
    }
}
