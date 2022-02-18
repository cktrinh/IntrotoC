using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Color+Pet Personality game
            Console.WriteLine("This is an attempt at some game which could be fun: What 'animal' are you?");
            Console.WriteLine("Now choose color [red/blue]");
            string color = Console.ReadLine();
            if(color == "red")
            {
                Console.WriteLine("Now choose animal [cat/dog]");
                string animal = Console.ReadLine();
                if(animal == "cat")
                {
                    Console.WriteLine("Red cat. Wow. Such a flex");
                }
                else
                {
                    Console.WriteLine("Red dog. Still a flex. Cool");
                }    
            }
            else
            {
                Console.WriteLine("Now choose animal [cat/dog]");
                string animal = Console.ReadLine();
                if (animal == "cat")
                {
                    Console.WriteLine("Blue cat. Ew");
                }
                else
                {
                    Console.WriteLine("Blue dog. You are impossible :rolling-eyes:");
                }
            }
        }
    }
}
