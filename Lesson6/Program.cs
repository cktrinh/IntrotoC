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
            for (int w = 0; w != width; w++)
            {
                Console.WriteLine();
                if (w == 0 || w == width - 1)
                {
                    for (int l = 0; l != length; l++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    for (int s = 0; s < length; s++)
                    {
                        if (s==0 || s==length-1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
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


            ///////////////// STUPID FLIP TRIANGLE/////////
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

