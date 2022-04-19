using System;

using System.Collections.Generic;

namespace other_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool wasThere = false;
            int howMany = 0;
            //declares a boolean variable
            List<int> numList = new List<int>();
            //declares a list for the numbers to be entered to
            Console.WriteLine("Enter 5 Numbers");

            for(int i = 0; i < 5; i++)
            {
                numList.Add(int.Parse(Console.ReadLine()));
                //adds the next 5 inputs into the console to the numList
            }
             Console.WriteLine("Enter another number");
            int sixth = int.Parse(Console.ReadLine());
                //asks for the user to input another number

            
            foreach (int num in numList)
            {
                if (num == sixth)
                {
                    howMany += 1;
                    wasThere = true;
                }
            }
            //goes through the entire list checking if the sixth number entered was in the list
            if (wasThere == false) 
            {
                Console.WriteLine(sixth + " was not entered previously");
            }
            else
            {
                Console.WriteLine("That number was entered " + howMany + " times already");
            }
            //if it was not in the list it says it wasnt
        }
    }
}
