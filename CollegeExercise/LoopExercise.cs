using System;

namespace CollegeExercise
{
    class LoopExercise
    {
        static void Main(string[] args)
        {
            // While Loop Exercise
            int k = 0;
            Console.WriteLine("While Loop");
            while (k <= 5)
            {
                Console.WriteLine($"{k}  {10-k}");
                k++;
            }
            // For Loop Exercise
            int f = 10;
            Console.WriteLine("For Loop");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}  {f}");
                f -= 2;
            }
           
        }
    }
}
