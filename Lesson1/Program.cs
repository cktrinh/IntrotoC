using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            float x = float.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");

            float y = float.Parse(Console.ReadLine());

            float sum = x + y;
            float product = x * y;
            float quotient = x / y;
            float difference = x - y;

            Console.WriteLine("The numbers you entered are " + x + " and " + y);
            Console.WriteLine("The sum of x and y: " + sum);
            Console.WriteLine("The product of x and y:" + product);
            Console.WriteLine("The quotient of x and y:" + quotient);
            Console.WriteLine("The difference of x and y:" + difference);
        }
    }
}
