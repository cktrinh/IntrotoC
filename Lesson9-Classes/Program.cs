using System;

namespace Lesson9_Classes
{
    //this is the syntax for declaring a class with the name Rectangle
    class Rectangle
    {
        //members, member fields
        private int width; //4 bytes //cannot access from outside
        private int height; //4 bytes

        //setter method: to set the value of the private member field
        public void SetWidth(int value) // can access from outside
        {
            width = value;
        }

        //getter method: to get the value of the private member field
        public int GetWidth()
        {
            return width;
        }

        public void Show() //method
        {
            Console.WriteLine(width + "x" + height);
        }
    }

    class Program
    {
        public int width;

        public static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            a.SetWidth(5);
            a.height = 10;

            a.Set(20, 30); // update the variable a with parameter

            Console.WriteLine(a.GetWidth() + "x" + a.height);












            Rectangle a = new Rectangle(); //55
            a.width = 20;
            a.height = 30;
            // For variable rectangle a, assign new instance of Rectangle
            // each member variable assigned an integer, then memory etc.

            Rectangle b = new Rectangle(); //92
            b.width = 40;
            b.height = 50;

            Console.WriteLine(a.width + " " + a.height);
            Console.WriteLine(b.width + " " + b.height);
            // In reality, "a" and "b" are integers, but special integers where you cannot do equations;

            a = b;
            // This does not change the member variables,
            // but it points to the same object, thus overwriting the ADDRESS OF THE OBJECT.


            Console.WriteLine(a.width + " " + a.height);
            Console.WriteLine(b.width + " " + b.height);

            int a = 10;
            int b = 20;


            //If the VALUE of the VARIABLE is = the ADDRESS of the OBJECT
            //we say that the VARIABLE is POINTING to the OBJECT
            // the ADDRESS of the VARIABLE is somewhere else, it's just holding the VALUE/ ADDRESS of the OBJECT
            // which is why it's POINTING







            //---
            int x = 5;
            int y = 10;

            //here is the ONE THING we are ALLOWED TO DO
            Rectangle myRectangle = new Rectangle();

            //the question is, WHAT THE FUCK IS NEW RECTANGLE()
            //when you write

            new Rectangle();

            //you tell the computer:

            // - Yo, computer, bro, I want you to create a fucking Rectangle object for me, yo

            //and then the computer is like:

            // - Ok bro, let's see.. what the fuck is a Rectangle

            //so the computer looks at your definition:

            //class Rectangle
            //{
            //    public int width;
            //    public int height;
            //}

            //and it thinks to itself:

            // - Ok so... a Rectangle is 2 variables: width and height, and they are both integers
            //that means they are both 4 bytes, and since we have 2 of them... we need a total of 8 bytes
            //for a Rectangle object

            //so then the computer looks at the grid (your RAM) and tries to find 8 consecutive cells that are
            //not taken by anyone else (open the pain thing from last night)

            //so the computer found 8-bytes of space at address 23 and claimed it for our object
            //then the number 23 becomes the result of `new Rectangle()`

            //so the computer is like:

            // - Yo bro, I created that Rectangle object for you, you can find it at address 23, ok??

            //and you're like:

            // - Thanks, computer, I'm gonna remember that number 23 in my lil variable here:


            Rectangle myRectangle = new Rectangle();

            //essentially it's as if you wrote

            Rectangle myRectangle = 23;

            //except you are not manually allowed to write

            myRectangle = 23; //because it's not always gonna be 23, it might be some other number

            //but you are allowed to write

            myRectangle = new Rectangle();

            //new Rectangle() tells the computer to go and find 8 bytes of space somewhere, claim it and give you the address

            //then since you wrote

            myRectangle = new Rectangle(); // what is this "..." !!!

            //that address gets stored into your variable, and now the variable myRectangle holds the number 23 inside


            //does this make sense?
            //im gonna call you in 20 min ok?ok
        }
    }
}
