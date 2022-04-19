using System;
using System.Collections.Generic;

namespace wordslist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();
            //declares a new list
            Console.WriteLine("Enter a list of words then say stop");
            while (true)
            {
                string strInput = Console.ReadLine();
                if (strInput == "stop")
                {
                    break;
                }
                else
                {
                    wordList.Add(strInput);
                }
            }
            //until the user writes stop it will continue adding anything said into the list
            int numOf = wordList.Count;
            //gets the amount of words in the list

                if (numOf == 0)
                {
                    Console.WriteLine("You did not input any words");
                }
                //if no words were entered says so
                else
                {
                    wordList.Reverse();
                    //inverts the list
                    foreach(string word in wordList)
                    {
                        Console.WriteLine(word);
                    }
                    //writes all the words to the console that are in the list
                }
        }
    }
}
