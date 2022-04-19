using System;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Names");
            string[] namesList = new string[5];
            //declares an array for the names to be inputed into
            for(int i = 0;i < 5; i++)
            {
                namesList[i] = Console.ReadLine();
            }
            //asks the user to enter 5 names and adds them to the array
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine("Hello " + namesList[i]);
            }
            //writes to the console what the 5 names were
        }
    }
}
