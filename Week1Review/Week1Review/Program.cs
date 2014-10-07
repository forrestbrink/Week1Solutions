using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        //declare a global variable to hold
        //the total number of loops executed
        static int loopCount = 0;

        static void Main(string[] args)
        {
            StringBuilding("seedpaths");
            //print out the number of loops performed
            Console.WriteLine(loopCount);

            //call the stringbuilding function to do
            //more loops
            StringBuilding("running a few more loops");
            //print out the number of loops performed
            Console.WriteLine(loopCount);

            //Call our ListPractice() fuction
            ListPractice();

                Console.ReadKey();
        }

        //building a string
        //take in a string and output a string 
        //with all vowels capitalized
        //and all consonants lowercase
        static void StringBuilding(string input)
        {
            //declare a string to hold
            //our output
            string output = "";

            //loop over the input to compare
            //each letter
            for (int i = 0; i < input.Length; i++)
            {
                //get a letter from the input
                //convert the character to a string
                string letter = input[i].ToString();

                //determine if the letter is a vowel
                string vowels = "aeiou";
                if (vowels.Contains(letter.ToLower()))
                {
                    //it is a vowel
                    output = output + letter.ToUpper(); 
                }
                else
                {
                    //its not a vowel.  add it a lowercase
                    //letter to our output
                    output = output + letter.ToLower();
                }
                //we did a loop, hooray!
                //add one to the loop counter
                loopCount = loopCount + 1;

            }
            //print the output
            Console.WriteLine(output);
        }
    
        //working with LISTS
        static void ListPractice()
        {
            //declare a new list of strings
            List<string> sportsList = new List<string>() { "Baseball", "Basketball", "Badmitton", "Lacrosse", "Luge", "Curling" };

            //print out the contents of sportsList using a for loop
            //in asceding order
            for (int i = 0; i < sportsList.Count; i++)
            {
                Console.WriteLine(sportsList[i]);
                //we did a loop, count it on the loopCount global version
                loopCount++;
            }

            //print out the contents of the sportsList using a 
            //for loop in reverse order
            //things to Note: .Count - 1, >= 0
            for (int i = sportsList.Count - 1; i >= 0; i = i - 1)
            {
                Console.WriteLine(sportsList[i]);
                loopCount++;
            }


            //list out the contents of the sportsList using a 
            //foreach loop
            foreach (var item in sportsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
