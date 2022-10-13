using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_Test
{
    class Cirkel : Teckning
    {
        public double Radius { get; set; }
        public Cirkel()
        {
            this.Radius = 5;
        }
        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            Console.Write($"Arean Cirkel: ");
            Console.WriteLine(Math.Round(area, 2));
            return area;
        }
    }
}
