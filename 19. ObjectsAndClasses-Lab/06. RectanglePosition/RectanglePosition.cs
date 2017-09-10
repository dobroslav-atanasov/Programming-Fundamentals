using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            int[] firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRectangle = new Rectangle
            {
                Left = firstInput[0],
                Top = firstInput[1],
                Width = firstInput[2],
                Height = firstInput[3]
            };

            Rectangle secondRectangle = new Rectangle
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };

            bool isInside = FindIsInside(firstRectangle, secondRectangle);
            Console.WriteLine(isInside ? "Inside" : "Not inside");
        }

        public static bool FindIsInside(Rectangle first, Rectangle second)
        {
            if (first.Left >= second.Left && first.Right <= second.Right && first.Top <= second.Top && first.Bottom >= second.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
    }
}
