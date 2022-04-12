using System;

namespace Lesson9_Classes
{
    class Rectangle
    {
        public double width;
        public double height;

        public double GetArea()
        {
            double area = width * height;
            return area;
        }
      
    }

    class Circle
    {
        public double radius;
        public double GetArea()
        {
            double area = radius * radius * 3.14;
            return area;
        }
    }

    class RightTriangle
    {
        private double a;
        private double b;

        public void SetA(double value)
        {
            a = value;
        }

        public double GetA()
        {
            return a;
        }

        public void SetB(double value)
        {
            b = value;
        }

        public double GetB()
        {
            return b;
        }

        public double GetArea()
        {
            double area = (a * b) / 2;
            return area;
        }
    }

    class Person
    {
        public string name; //variable => members/fields/member fields
        public string hairColor;
        public string eyeColor;

        public Person(string theName) //special method, constructor
        {
            name = theName;
        }

        public void SayHello() //function => method
        {
            Console.WriteLine(name + " says hello!");
        }

        public void Say(string words)
        {
            Console.WriteLine(name + " says: " + words);
        }
    }

    class Car
    {
        public int numberOfWheels;
        public string color;
        public string brand;
    }

    class Marker
    {
        string colorMarker;
        string colorMarkerCap;

        public Marker(string colorMarker)
        {
            this.colorMarker = colorMarker;
            colorMarkerCap = colorMarker;
        }

        public string GetColor()
        {
            return colorMarker;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Python:
            //myMarker = Marker('green')
            //theColor = myMarker.getColor()

            //C#:
            Marker myMarker = new Marker("green");
            string theColor = myMarker.GetColor();




            return;
            //---

            RightTriangle triangle1 = new RightTriangle();

            Console.WriteLine("Enter a: ");
            triangle1.SetA(double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter b: ");
            triangle1.SetB(double.Parse(Console.ReadLine()));

            Console.WriteLine("a is: " + triangle1.GetA());
            Console.WriteLine("b is: " + triangle1.GetB());

            Console.WriteLine("The area is: " + triangle1.GetArea());
        }
    }
}
