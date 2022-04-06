using System;

namespace Lesson8_Functions
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        //`void` means there is no result, make sense?ok
        static void ShowSum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum is: " + sum);
        }

        //this `int` here specifies the type of the result
        static int Sum(int a, int b) //notice how I didn't use `void` this time
        {
            int sum = a + b;
            return sum;
        }

        //make a function that takes a person's first name and last name as parameters and gives you the full name as a result:

        static string GetFullName(string firstName, string lastName) //ignore the name being red
        {
            string fullName = firstName + " " + lastName; //this is your function
            return fullName;
        }

        static void Main(string[] args)
        {
            ShowSum(5, 10); //this will display 15 on the screen, right?ye

            int result = Sum(20, 30); //unlike the previous function, this one has a RESULT (a RETURN VALUE)
            //after the function is done executing, it hits the RETURN statement
            //the RETURN statement determines the RESULT of the function
            //that result is then assigned to the `result` variable

            //now this starts to look more like cos() and sin() from math, right?ok

            //so that code you wrote with the Console.WriteLine() would actually still go here, like this:

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your full name is: " + GetFullName(firstName, lastName));

            //ok let's make a more interesting function...
            //hmmm
            //why are we doing this? i already knew functions.
            //ok
            //let's continue then
            // i did many programs in my pythton 101 class. i dont understand why we keep going back. 
            //ensuring you don't have gaps
            //make Lesson9-Classes
            // i understand you want me to be thorough and understand things. but I have a lot of hw to do and I can't just ignore them. 
            //other subjects?
            // this homework only has 200 lines of code. I'm not that good Vladi
            // plus look at this
            //

            Console.WriteLine(result);
        }
    }
}
