using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLessons
{
    class Shape
    {
        protected string color;
        public Shape(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color) 
        {
            this.color = color;
        }
    }

    class Triangle : Shape
    {
        private double baseLength;
        private double heightLength;
        
        public Triangle(string color, double baseLength, double heightLength) : base(color)
        {
            this.baseLength = baseLength;
            this.heightLength = heightLength;
        }

        public double GetArea()
        {
            return this.baseLength * this.heightLength / 2;
        }

        public double GetBaseLength()
        {
            return this.baseLength;
        }

        public double GetHeightLength()
        {
            return this.heightLength;
        }
    }

    class  Rectangle:Shape
    {
        private double length, width;
        public Rectangle(string color, double length, double width) : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return this.length;
        }

        public double GetWidth()
        {
            return this.width;
        }
        public double GetArea()
        {
            return this.length * this.width;
        }

        public double GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }
    }

    class Square : Rectangle
    {
        public Square(string color, double side) : base(color, side, side)
        {
        }
    }
}
