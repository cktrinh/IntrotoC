using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            // user inputs first and end number using loop //
            Console.WriteLine("Enter first number:");
            string userInput1 = Console.ReadLine();
            double userNumberFirst = Convert.ToDouble(userInput1);
            Console.WriteLine("Enter end number:");
            string userInput2 = Console.ReadLine();
            double userNumberEnd = Convert.ToDouble(userInput2);
            while (userNumberEnd <= userNumberFirst)
            {
                Console.WriteLine("The end number cannot be equal or smaller to first. Please re-enter the end number:");
                userInput2 = Console.ReadLine();
                userNumberEnd = Convert.ToDouble(userInput2);
            }

            double i;
            Console.WriteLine("Baby, this is what you came for ~~: ");
            for (i = userNumberFirst;i<=userNumberEnd;i++)
            {
                Console.WriteLine(i);
            }

            //////////// COUNT USING WHILE LOOP ////////////////
            //string userInput;
            //double userNumber;
            //int i = 0;
            //Console.WriteLine("Enter a whole, positive number:");
            //userInput = Console.ReadLine();
            //userNumber = Convert.ToDouble(userInput);
            //while (userNumber < 0)
            //{
            //    Console.WriteLine("I said WHOLE, POSITIVE. Re-enter now: ");
            //    userInput = Console.ReadLine();
            //    userNumber = Convert.ToDouble(userInput);

            //}
            //Console.WriteLine("The series of numbers is as follows: ");
            //while (i < userNumber)
            //{
            //    i ++;
            //    Console.WriteLine(i);
            //}





            ////////// SIMPLE WHILE LOOP /////////////
            //int i = 0;

            //int userInput = 10;

            //while (i < userInput)
            //{
            //    i = i + 1;
            //    Console.WriteLine(i);
            //}
        }
    }
}
