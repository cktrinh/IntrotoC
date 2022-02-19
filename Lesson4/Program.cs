using System;

namespace Lesson4
{
    class Program
    {
            //keep asking for pasword
        static void Main(string[] args)
        {
            string correctPassword = "trinniedabest";
            string userPassword;

            do
            {
                Console.WriteLine("Please enter your password:");
                userPassword = Console.ReadLine();
            }
            while (correctPassword != userPassword);

            Console.WriteLine("Access granted.");
        }
    }
}
