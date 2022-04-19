using System;

namespace value_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            //Creates an array with these numbers in it
            int answer = 0;
            //declares the answer variable
            for (int i = 0; i < 10; i++)
            {
                answer = answer + values[i];
            }
            //adds all the numbers up
            Console.WriteLine(answer);
            //writes the numbers to the console
        }
    }
}
