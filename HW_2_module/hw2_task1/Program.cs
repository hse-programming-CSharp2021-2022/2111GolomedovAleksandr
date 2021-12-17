using System;

namespace hw2_task1
{
    class Program
    {
        static void Display(MyComplex cs)
        {
            Console.WriteLine($"real={cs.re:F3}, image={cs.im:F3}");
        }

        static void Main()
        {
            MyComplex c1 = new MyComplex(4, 3.3);
            Console.WriteLine("Модуль исходного комплексного числа = " + c1.Mod());
            while (c1)
            {
                Console.Write("c1 => ");
                Display(c1);
                c1--;
            }
            Console.WriteLine("Модуль полученного числа = " + c1.Mod());
            Console.WriteLine("---------------------");
            MyComplex a = new MyComplex(1.1, 2.2);
            MyComplex b = new MyComplex(3.3, 4.4);
            Console.Write($"a => ");
            Display(a);
            Console.Write($"b => ");
            Display(b);
            Console.Write($"a+b => ");
            Display(a + b);
            Console.Write($"a-b => ");
            Display(a - b);
            Console.Write($"a*b => ");
            Display(a * b);
            Console.Write($"a/b => ");
            Display(a / b);
        }
    }
}