using System;

namespace hw_1_task2
{
    public class Polygon
    {
        public int Num { get; }

        public double Radius { get; }

        public Polygon(int nun = 3, double rad = 1)
        {
            Num = nun;
            Radius = rad;
        }

        public double Perimeter
        {
            get
            {
                double term = Math.Tan(Math.PI / Num);
                return 2 * Num * Radius * term;
            }
        }

        public double Area => Perimeter * Radius / 2;
    } // Polygon 
}