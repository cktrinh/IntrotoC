using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hotColors =
            {
                "red", "pink"
            };
            string[] coldColors =
            {
                "green","blue"
            };
            string[] cuteAnimals =
            {
                "cat"
            };
            string[] loyalAnimals =
            {
                "dog"
            };
            //Color+Pet Personality game
            Console.WriteLine("What personality are you?");
            Console.WriteLine("Choose color [red/blue/green/pink]");
            string color = Console.ReadLine();
            Console.WriteLine("Choose animal [cat/dog]");
            string animal = Console.ReadLine();
            string personality1 = "";
            string personality2 = "";
            if(hotColors.Contains(color))
            {
                personality1 = "strong";
            }
            else if(coldColors.Contains(color))
            {
                personality1 = "weak";
            }
            else if(cuteAnimals.Contains(animal))
            {
                personality2 = "cute";
            }
            else if(loyalAnimals.Contains(animal))
            {
                personality2 = "loyal";
            }
            Console.WriteLine("You are " + personality1 + " and " + personality2);
        }
    }
}
