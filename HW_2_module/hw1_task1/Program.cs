using System;

namespace hw1_task1
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public Point() : this(0, 0)
            {
            } // конструктор умолчания

            public double Ro => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

            public double Fi
            {
                get
                {
                    if (X > 0 && Y >= 0)
                        return Math.Atan(Y / X);
                    if (X > 0 && Y < 0)
                        return Math.Atan(Y / X) + 2 * Math.PI;
                    if (X < 0)
                        return Math.Atan(Y / X) + Math.PI;
                    if (X == 0 && Y > 0)
                        return Math.PI / 2;
                    if (X == 0 && Y < 0)
                        return 3 * Math.PI / 2;
                    if (X == 0 && Y == 0)
                        return 0;
                    return 0;
                }
            }

            public string PointData
            {
                // СВОЙСТВО 
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return string.Format(maket, X, Y, Ro, Fi);
                }
            }
            
            static void Main()
            {
                Point a, b, c;
                a = new Point(3, 4);
                Console.WriteLine(a.PointData);
                b = new Point(0, 3);
                Console.WriteLine(b.PointData);
                c = new Point();
                double x = 0, y = 0;
                do
                {
                    Console.Write("x = ");
                    double.TryParse(Console.ReadLine(), out x);
                    Console.Write("y = ");
                    double.TryParse(Console.ReadLine(), out y);
                    c.X = x;
                    c.Y = y;
                    Point[] points = {a, b, c};
                    
                    int Comparator(Point left, Point right)
                    {
                        if (left.Ro == right.Ro)
                            return 0;
                        else if (left.Ro < right.Ro)
                            return -1;
                        else
                            return 1;
                    }
                    
                    Array.Sort(points, Comparator);
                    foreach (var point in points)
                    {
                        Console.WriteLine(point.PointData);
                    }
                } while (x != 0 | y != 0);
            }
        }
    }
}