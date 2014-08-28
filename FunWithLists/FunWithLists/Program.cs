using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a new list of strings for a menu
            List<string> myMenu = new List<string>() {"Pizza", "Tacos", "Hummus", "Instant Potatoes"};

            //add one more menu item to our list
            myMenu.Add("Deep Fried Twix");

            //Loop through our menu and print each item
            for (int i = 0; i < myMenu.Count; i++)
            {
                Console.WriteLine(myMenu[i]);
            }

            //remove things from a list
            myMenu.RemoveAt(1);

            //Another EASIER way of printing out an array
            Console.WriteLine(string.Join(", ", myMenu));

            //Loop through the list again to make Twix pop in our list
            for (int i = 0; i < myMenu.Count; i++)
            {
                string item = myMenu[i];
                if (item.Contains("Twix"))
                {
                    Console.WriteLine(item.ToUpper());
                }
                else
                {
                    Console.WriteLine(item);
                }

            }

            //keep the window open
            Console.ReadKey();
        }
    }
}
