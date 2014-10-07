using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //call our Yodaizer function
            Yodaizer("I like Code");

            //call our TextStats function
            TextStats("Today is Friday.  Tomorrow is Saturday.  The day after that would be Sunday.");

            //call  our DashInsert function
            DashInsert(8675309);

            //creat a loop for numbers 0 to 20
            for (int i = 0; i <= 20; i = i + 1)
            {
                FizzBuzz(i);
            }
            for (int i = 79; i < 92; i++)
            {
                FizzBuzz(i);
            }
            {
                Console.ReadKey();
            }
        }
              static void FizzBuzz(int number)
        {
                  //if number is divisible by 3 and 5
            if (number % 5 == 0 && number % 3 == 0)
            {
               //write FizzBuzz
                Console.WriteLine("FizzBuzz");
            }
                //if not then ask if number is divisible by just 5
            else if (number % 5 == 0)
            {
                //if true, write Fizz
                Console.WriteLine("Fizz");
            }
                //if not, ask if number is divisible by 3
            else if (number % 3 == 0)
            {
                //if it is, write Buzz
                Console.WriteLine("Buzz");
            }
                //if number is not divisible by either 5 or 3,
                //print out number
            else if (number % 5 != 0 && number % 3 != 0)
            {
                Console.WriteLine(number);
            }
        }
        //create a function yodaizer that takes a parameter "text"
              static void Yodaizer(string text)
              {
                   List<string> list = text.Split(' ').ToList();
            
            //Ask if there are three words
            if (list.Count == 3)
            {
                //Reverse order of words
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.Write(list[i] + ", ");
                }
            }
            //if not
            else
            {
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write(text[i]);
                }
              }
              }
        //creat a function called TextStats that takes parameter "input"
              static void TextStats(string input)
              {
                  List<string> textList = input.Split(' ').ToList();
                  string vowels = "aeiou";
                  string letters = "abcdefghijklmnopqrstuvwxyz";
                  int numVowels = 0;
                  int numConsonants = 0;
                  
                  int specialCharacters = 0;
                  string longWord = textList[0];
                  string shortWord = textList[0];
                  string secLongWord = textList[0];
                  for (int d = 0; d < input.Length; d++)
                  {
                      input.ToLower();
                      //does it contain any special characters?
                      if (!(letters.Contains(input[d])))
                      {
                          specialCharacters++;
                      }
                      //ask if it contains any vowels?
                      if (vowels.Contains(input[d]))
                      {
                          numVowels++;
                      }
                      //if not, is ita vowel?
                      else
                      {
                          numConsonants++;
                      }
                      for (int i = 0; i < textList.Count; i++)
                      {
                         
                          if (textList[i].Length > longWord.Length)
                          {
                              secLongWord = longWord;
                              longWord = textList[i];
                          }

                          //find the shortest word length
                          if (textList[i].Length < shortWord.Length)
                          {
                              shortWord = textList[i];
                          }
                      }
                  }
              }
                     static void DashInsert(int number)
        {
           
            int num1 = 2;
            string output = "";

            //create a loop asking if each number is odd or not
            foreach (var item in number.ToString())
            {
                Convert.ToInt32(item);
                if (num1 % 2 != 0 && number % 2 != 0)
                {
                    output = output + "-" + item;
                }
                else
                {
                    output = output + item;
                }
                num1 = item;
             }
            Console.WriteLine(output);
        }
              
    }
}
