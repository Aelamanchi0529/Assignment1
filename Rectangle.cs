using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int Width;
        public Rectangle()
        {
            length = 1;
            Width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.Width = width;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int Length)
        {
            this.length = Length;
            return this.length;

        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int Width)
        {
            this.Width = Width;
            return this.Width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + Width);
        }

        public int GetArea()
        {
            return (length * Width);
        }

    }
}



