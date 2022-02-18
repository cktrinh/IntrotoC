using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("Sorry, you are too young to enter the porn site. However, you can try Literotica"); //the code will either take this path
            }
            else if (age==18)
            {
                Console.WriteLine("You're just about the right time for great s*x");
            }
            else
            {
                Console.WriteLine("Too old. go to bed");
            }
            Console.WriteLine("Choose your age wisely");
        }
    }
}
