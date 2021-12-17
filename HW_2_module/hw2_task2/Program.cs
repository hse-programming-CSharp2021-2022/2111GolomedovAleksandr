using System;

namespace hw2_task2
{
    class Program
    {
        static void Main()
        {
            ConsolePlate symb1 = 
                new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate symb2 = 
                new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            Console.WriteLine("Введите N от 2 до 34:");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N) && N >= 2 && N < 35))
            {
                Console.WriteLine("Некорректный ввод.");
                Console.WriteLine("Введите N от 2 до 34:");
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    ConsolePlate now = (i + j) % 2 == 0 ? symb1 : symb2;
                    Console.ForegroundColor = now.PlateColor;
                    Console.BackgroundColor = now.BackColour;
                    Console.Write(now.PlateChar);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
    }
}