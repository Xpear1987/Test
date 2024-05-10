using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            squareArea s = new squareArea(4.5);

            circleArea c = new circleArea(3.7);

            triangleArea t = new triangleArea(7.8, 6.3);

            Console.ReadLine();
        }
    }
}
