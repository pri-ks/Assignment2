using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int l, int b)
        {
            length = l;
            width = b;
        }
        private int length;
        public int Length
        {
            get { return length; }
        }
        private int width;
        public int Width
        {
            get { return width; }
        }

        public int GetLength()
        {
            return Length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return Length;
        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return Width;
        }
        public int GetPerimeter()
        {
            int perimeter = 2 * (length + width);
            return perimeter;
        }
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
