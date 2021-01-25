using System;

namespace TakingInput
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Operating sum operation
            int a, b;

            Console.WriteLine("Enter a Number one");
            string input_1 = Console.ReadLine();
            
            Console.WriteLine("Enter a Number two");
            string input_2 = Console.ReadLine();

            // Converting a Input string to integer
            a = Convert.ToInt32(input_1);
            b = Convert.ToInt32(input_2);
            int ans = a + b;
            Console.WriteLine("{0} + {1} = {2}",a ,b , a + b);
            Console.WriteLine($"{a} + {b} = {ans}");

            Console.ReadKey();
        }
    }
}
