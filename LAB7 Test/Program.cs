using System;

namespace LAB7_Test
{
    class Program
    {
        static void Main(string[] args)
        {  
            Teckning T1 = new Rektangel();
            Teckning T2 = new Cirkel();
            Teckning T3 = new Fyrkant();

            Teckning[] T4 = new Teckning[] { T1, T2, T3 };
            foreach (Teckning teckning in T4)
            {
                teckning.Area();
            }
        }
    }
}
