using HerdarvsInterface.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerdarvsInterface.Entities
{
    class Rectangle : Shape

    {
        public double Width { get; set; }
        public double Height { get; set; }
       

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;

        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return 
                 "Color =  "
                + Color
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
