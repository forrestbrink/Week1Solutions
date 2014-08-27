﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
          //call FlipACoin100Times() function
           //FlipACoin();

            //call our whileLoopTest() function
           // whileLoopTest();

            FlipForHeads(1000);

            //keep the console window open
            Console.ReadKey();
        }

        //FUNCTIONS GO HERE
        static void whileLoopTest()
        {
            //while loop 1 -> 10 

            //declare our incrementor
            int i = 1;
            //define the while loop condition 
            while (i <= 10)
            {
                Console.WriteLine(i);
                //make sure to increment i
                i = i + 1;
            }
        }

        static void FlipACoin(int flips)
        {
            //declaring integers to hold how many times
            //we've flipped heads or tails
            int countHeads = 0;
            int countTails = 0;

            //create a random number generator
            //to "flip" a coin
            Random rng = new Random();
            
            //flip the coin as many times as the flips
            //parameter says we should
            for (int i = 0; i < flips; i = i + 1)
            {
                //flip that ooin
                int flip = rng.Next(0, 2);
                if (flip == 0)
                {
                    //if it was a tails, increase our counter
                    countTails = countTails + 1;
                }
                else
                {
                    countHeads = countHeads + 1;
                }
            }
            //output the number of heads
            Console.WriteLine("# of Heads: " + countHeads);
            Console.WriteLine("# of Tails: " + countTails);
        }

        //flip a coin until we get X number of heads
        static void FlipForHeads(int numHeads)
        {
            //counts how many heads we flipped
            int headsFlipped = 0;
            //count the total flips
            int totalFlips = 0;
            //random number generator to
            //"flip" our coin
            Random rng = new Random();

            //do a while loop to flip coins 
            //until we have reached the desired
            //number of heads
            while (numHeads != headsFlipped)
            {
                //flip a coin
                if (rng.Next(0, 2) == 0)
                {
                    //its a head
                    headsFlipped = headsFlipped + 1;
                }
                //add a flip to our total flip count
                totalFlips = totalFlips + 1;
            }
            //write the output of how many flips it took
            //to find all the heads
            Console.WriteLine("It took " + totalFlips + " flips to get " + numHeads + " heads");
        }
    }
}
