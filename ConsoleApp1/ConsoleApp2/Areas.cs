using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class squareArea
    {
        public double side;
        public squareArea(double squareside)
        {
            side = squareside;
            Display();
        }
        
        private double GetArea()
        {
            return side * side;
        }

        public void Display()
        {
            Console.WriteLine("Side: {0}", side);
            Console.WriteLine("Area: {0}", GetArea());
        }

    }

    class circleArea
    {
        public double radius;

        public circleArea(double circleradius)
        {
            radius = circleradius;
            Display();
        }
        
        private double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public void Display()
        {
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class triangleArea
    {
        public double height, tbase;

        public triangleArea(double triheight, double tribase)
        {
            height = triheight;
            tbase = tribase;
            Display();
        }


        private double GetArea()
        {
            return (height * tbase) / 2;
        }

        public void Display()
        {
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Base: {0}", tbase);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
