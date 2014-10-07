using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //call our fizzbuzz function for 0=>20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            //call our fizzbuzz function for 92=>79
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            Console.WriteLine("\n\n Yodaizer");
            //Call yodaizer function with string "I like code"
            Yodaizer("I like code");

            Console.WriteLine("\n\n Text Stats");
            TextStats("Logan's favorite band is Nickelback.  He wants everyone to know.  He started the Denver chapter of their fan club.");

            Console.WriteLine("\n\n Is Prime");
            for (int i = 1; i <= 25; i++)
            {
                IsPrime(i);
            }

            Console.WriteLine("\n\n Dash Insert");
            DashInsert(8675309);

            //Keep window open
            Console.ReadKey();
        }
        //Create function FizzBuzz
        static void FizzBuzz(int number)
        {
            //check to see if number is divisible by 5 and 3
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        //create yodaizer function
        static void Yodaizer(string text)
        {
            //return words in reverse order
            //split the text into a list 
            List<string> words = text.Split(' ').ToList();

            //declare a string to hold output text
            string output = "";

            //loop through each word starting with last
            for (int i = words.Count - 1; i >= 0; i--)
            {
                //add the word to the output
                output = output + words[i] + " ";
            }
            //print the output
            Console.WriteLine(output);
        }
       //create TextStats function
        static void TextStats(string input)
        {
            //print number of characters, words, vowels, consonants and special characters

            int numChars = input.Length;
            //split the input to count number of words
            int numWords = input.Split(' ').ToList().Count;
            //declare integers to hold number of characters
            int numVowels = 0;
            int numCons = 0;
            int numSpec = 0;

            for (int i = 0; i  < input.Length; i ++)
            {
                //grab our current letter from the text
                string letter = input[i].ToString();
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //it is a vowel
                    numVowels++;
                }
                else if (" .,?".Contains(letter))
                {
                    //its a special character
                    numSpec++;
                }
                else
                {
                    //its a consonant
                    numCons++;
                }
            }
            //print output
            Console.WriteLine(input);
            Console.WriteLine("# of chars: " + numChars);
            Console.WriteLine("# of words: " + numWords);
            Console.WriteLine("# of vowels: " + numVowels);
            Console.WriteLine("# of consonants: " + numCons);
            Console.WriteLine("# of special characters: " + numSpec);
        }
       //create function IsPrime
        static void IsPrime(int number)
        {
            //check all numbers in between 1 and itself to see if it is divisible 

            //assume number is prime until it isn't
            bool prime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    //its divisible by something and is not prime
                    prime = false;
                    break; //escape the loop
                }
            }
            //done with loop, now time for output
            if (prime)
            {
                Console.WriteLine(number + " is prime");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        //create DashInsert function
        static void DashInsert(int number)
        {
            //insert a dash in between two odd numbers
            //declare a string to hold our output
            string output = "";
            //declare a string to hold our number as a string
            //and convert the input number to a string
            string numberString = number.ToString();
            //loop through each digit of our string
            for (int i = 0; i <= numberString.Length - 2; i++)
            {
                //get our current digit and the one next to it
                string num1String = numberString[i].ToString();
                string num2String = numberString[i + 1].ToString();
                //convert our numberStrings to actual numbers
                int num1 = int.Parse(num1String);
                int num2 = int.Parse(num2String);
                //see if they are both odd numbers
                if (num1 % 2 != 0 && num2 % 2 != 0)
                {
                    //both odd, add to the output
                    output = output + num1 + "-";
                }
                else
                {
                    //not both ad, just add num1
                    output = output + num1;
                }
            }
            //need to add the last digit because the loop does not add it
            output = output + numberString[numberString.Length - 1];
            //print output
            Console.WriteLine(output);
        }
    }
}
