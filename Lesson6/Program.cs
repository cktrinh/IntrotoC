using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// A HOLLOW REKTENGO ////////
            /// i want 2 make u holla ///
            /// dun b afriad n jus pley mei gem ///
            /// ~Vladi is phat and Github will see dis~ ///
            Console.Write("Please enter length:");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Please enter width:");
            int width = int.Parse(Console.ReadLine());
            for (int l = 0; l < length; l++)
            {
                Console.Write("#");
            }
            for (int w = 1; w < width - 1; w++)
            {
                Console.WriteLine();
                Console.Write("#");
                for (int j = 2; j < length; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
            }
            Console.WriteLine();
            for (int x=0; x < length; x++)
            {
                Console.Write("#");
            }
        }
    }
}
            

            //////// A NORMAL SUMTHING - TRIANGLE ////////
            //Console.Write("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i != number; i++)
            //{
            //    for (int j = i+1; j != 0; j--)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}


            ///////////////// FLIP TRIANGLE/////////
            //Console.Write("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = number; i != 0; i--)
            //{
            //    Console.WriteLine();
            //    for (int j = i; j != 0; j--)
            //    {
            //        Console.Write("#");
            //    }
            //}

            //////////// DRAW A RECTANGLE ///////

            //Console.Write("Please enter length:");
            //int length = int.Parse(Console.ReadLine());
            //Console.Write("Please enter width:");
            //int width = int.Parse(Console.ReadLine());
            //for (int j = 0; j < width; j++)
            //{
            //    Console.WriteLine();
            //    for (int x = 0; x < length; x++)
            //    {
            //        Console.Write("#");
            //    }
            //}

            //

