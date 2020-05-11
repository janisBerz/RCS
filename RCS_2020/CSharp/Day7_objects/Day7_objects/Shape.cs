using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_objects
{
    class Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }
        public int SideE { get; set; }

        public Shape(int sideA, int sideB, int sideC, int sideD, int sideE)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
            SideE = sideE;
        }
        public Shape(int sideA, int sideB, int sideC, int sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
        public Shape(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

        }

        // ievada malu garumu

        // pasaka, kas par figuru un izvada visus malu garumus 
        // pasaka, kas par figuru un  aprekina un izvada perimetru

        public void Perimeter()
        {
            Console.WriteLine($"Perimetrs: { SideA + SideB + SideC + SideD + SideE}");
        }

        public void Print()
        {
            Console.Write($"Malu garumi: {SideA } {SideB } {SideC }");
            if (SideD >0)
            {
                Console.Write(" " + SideD);
            }
            if (SideE > 0)
            {
                Console.Write(" " + SideE);
            }
        }
    }
}
