using System;

namespace Lesson7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1337;
            int[] arr = { 5, 10, 15 };
            //Write a program that asks the user how many names he wants to enter
            //then it asks him to enter them one by one, you store them into an array
            //then when he is finished, it prints out all the names he wrote again in a list

            Console.WriteLine(x); //accessing regular variable
            Console.WriteLine(arr[0]); //accessing array element, will print 5

            Console.WriteLine(arr[1]); //will print 10
            Console.WriteLine(arr[2]); //will print 15
            Console.WriteLine(arr[3]); //will crash the program because you are trying to access an element outside of the range of the array


            x = 50; //changing variable
            arr[0] = 30; //changing array element

            //an array is almost the same as the list in Python that you are familiar with, but arrays are simpler
            //once you create an array of 3 elements like above
            //you cannot remove or add elements from the array, it always has a fixed size of 3
            //another way you can do this is:
            //another way to create an array you mean? yes

            // does this "int" mean that it defines the type?
            // what if it's string
            //yes, so all array elements must be of the same type

            int[] //array of ints
            string[] //array of strings
            double[] //array of doubles, etc

            int[] something = new int[5]; //this determines the LENGTH of the array when you create it
            something[0] = 100; //0 is always the FIRST element of the array, hence all the jokes programmers count from 0 blabla
            something[1] = 200;
            something[2] = 300;
            something[3] = 500;
            something[4] = 9999; //LENGTH-1 is the last element of the array

            // can i do something[len(-1)] = 9999; here ?
            //ok so


            Console.WriteLine(something.Length); //this will give you the length of the array
            //you can do:

            Console.WriteLine(something[something.Length - 1]); //to acccess the last element
            //is this what u meant?
            // no. what if i want to assign the last variable
            something[something.Length - 1] = 3423423;
            // right thats what i meant

            Console.WriteLine(something[4]);

       

            // you can also use a variable when creating an array like:

            int trinnie = 6;

            int[] vladi = new int[trinnie];
            vladi[0] = 10;
            vladi[1] = 20;

            vladi[5] = 30; //the ones I did not assign 2,3,4 will have a value of 0

            Console.WriteLine(vladi.Length); // 6 - why 6? shhh
        }
    }
}
