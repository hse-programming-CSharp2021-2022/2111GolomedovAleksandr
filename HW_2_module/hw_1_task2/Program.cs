using System;
using System.Collections.Generic;
using System.Linq;

namespace hw_1_task2
{
    class Program
    {
        static void GetIndexMinMax(List<Polygon> polygons, out int indexMin, out int indexMax)
        {
            double minArea = double.MaxValue;
            double maxArea = -1;
            indexMin = -1;
            indexMax = -1;
            for (int i = 0; i < polygons.Count; i++)
            {
                if (polygons[i].Area < minArea)
                {
                    minArea = polygons[i].Area;
                    indexMin = i;
                }
                if (polygons[i].Area > maxArea)
                {
                    maxArea = polygons[i].Area;
                    indexMax = i;
                }
            }
        }
        
        static void Main()
        {
            List<Polygon> polygons = new List<Polygon>();
            while (true)
            {
                Console.Write("Введите число сторон: ");
                string numberInput = Console.ReadLine();
                Console.Write("Введите радиус: ");
                string radInput = Console.ReadLine();
                if (!(int.TryParse(numberInput, out int number) &&
                      double.TryParse(radInput, out double rad)))
                {
                    Console.WriteLine("Некорректный ввод.");
                    continue;
                }

                if (number == 0 && rad == 0)
                {
                    break;
                }
                else if (number < 3 || rad < 0)
                {
                    Console.WriteLine("Некорректный ввод.");
                    continue;
                }
                
                polygons.Add(new Polygon(number, rad));
                GetIndexMinMax(polygons, out int indexMin, out int indexMax);
                for (int i = 0; i < polygons.Count; i++)
                {
                    Console.Write($"N={polygons[i].Num}; " + 
                                  $"R={polygons[i].Radius}; " + 
                                  $"P="+ $"{polygons[i].Num:F3}" + "; ");
                    if(i == indexMin)
                        Console.ForegroundColor = ConsoleColor.Green;
                    if(i == indexMax)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"S="+ $"{polygons[i].Area:F3}" + ";\n");
                    Console.ResetColor();
                }
            }
        }
    }
}