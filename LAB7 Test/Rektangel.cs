using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_Test
{
    class Rektangel : Teckning
    {
        public double Height { get; set; }
        public double Length { get; set; }
        public Rektangel()
        {
            this.Height = 5;
            this.Length = 6;
        }
        public override double Area()
        {
            double area = Height * Length;
            Console.Write($"Area Rektangel: ");
            Console.WriteLine(Math.Round(area, 2));
            return area;
        }
    }
}
