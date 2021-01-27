using System;

namespace arrays
{
    public class Arrays
    {
        public void _array()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            // Character Array
            char[] arr = {'B','I','S','M','I','L','L','A','H'};
            Console.Write("My Text form Character array ");
            Console.WriteLine(arr);

            // Integer Array
            int[] arr1 = { 0, 3, 4, 6, 7, 4, 9, 3, 4, 2, 3 };
            Console.Write("My Number form Int array ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }
            Console.ResetColor();
        }
    }
}
