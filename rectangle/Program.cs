using System;
using System.IO;

namespace rectangle
{
    class Rectangle
    {
        private int _a;
        private int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public float GetSquare()
        {
            var s = _a * _b;
            return s;
        }

        public float Perimeter()
        {
            var p = (_a + _b) * 2;
            return p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new Rectangle[3];

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Rectangle #{0}", i);

                string aStr;
                int a;
                do
                {
                    Console.Write("enter a: ");
                    aStr = Console.ReadLine();
                } while (!int.TryParse(aStr, out a));

                string bStr;
                int b;
                do
                {
                    Console.Write("enter b: ");
                    bStr = Console.ReadLine();
                } while (!int.TryParse(bStr, out b));

                var rectangle = new Rectangle(a, b);
                rectangles[i] = rectangle;
            }

            for (int i = 0; i < 1; i++)
            {
                Console.Write("P: {0}, S: {1}",rectangles[i].Perimeter(),rectangles[i].GetSquare() );
            }
        }
    }
}