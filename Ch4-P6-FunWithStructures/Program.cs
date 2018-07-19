using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P6_FunWithStructures
{
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        public Point(int x ,int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }
        
        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }
        
        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(  " Lec 4 - Project 6 - Structures in C# ");
            //Console.WriteLine("***** A First Look at Structures *****\n");

            //// Create an initial Point.
            //Point myPoint;
            //myPoint.X = 349;
            //myPoint.Y = 76;
            //myPoint.Display();

            //// Adjust the X and Y values.
            //myPoint.Increment();
            //myPoint.Display();

            #region Creating structure variable

            //Point myPoint = new Point();
            //  Point myPoint = new Point(2, 2);

            //    myPoint.Display();

            #endregion

            int i = 3;

            Console.ReadLine();
        }
    }
}
