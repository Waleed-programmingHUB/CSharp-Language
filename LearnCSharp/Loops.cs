using System;

// NameSpace
namespace Loop
{
    // Class
    public class Loops
    {
        // Global Variables
        int a = 10;
        int i;
        public void loop_for(/* Function */)
        {
        // For Loop
            for (i = 1; i <= a; i++)
            {
                Console.WriteLine($"Bismillah For Loop {i}");
            }
        }
        public void loop_while(/* Function */)
        {
         i = 1;
        // While Loop
            while(i <= a)
            {
                Console.WriteLine($"Bismillah While Loop {i}");
                i++;
            }
        }
        public void loop_do_while(/* Function */)
        {
         i = 1;
        // While Loop
            do
            {
                Console.WriteLine($"Bismillah Do While Loop {i}");
                i++;
            }
            while (i <= a) ;
        }
    }
}
