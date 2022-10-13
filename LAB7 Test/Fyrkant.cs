using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_Test
{
    class Fyrkant : Teckning
    {
        public double Bas { get; set; }
        public Fyrkant()
        {
            this.Bas = 5;
        }
        public override double Area()
        {
            double area = Bas * Bas;
            Console.Write($"Arean Fyrkant: ");
            Console.WriteLine(Math.Round(area, 2));
            return area;
        }
    }
}
