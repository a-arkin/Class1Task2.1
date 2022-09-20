using System;

namespace Class1Task2._4
{
    class Program
    {
        static void Main(string[] args)
            // квадратное уравнение - (a*(x^2)) + (b*x) + c = 0
        {
            Console.WriteLine("Введите значение a");
            string a0 = Console.ReadLine();
            double a = double.Parse(a0);
            Console.WriteLine("Введите значение b");
            string b0 = Console.ReadLine();
            double b = double.Parse(b0);
            Console.WriteLine("Введите значение c");
            string c0 = Console.ReadLine();
            double c = double.Parse(c0);
            double D = (b * 2) - (4 * a * c);
            if (D<0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (D==0)
            {
                Console.WriteLine("Из такого выражения можно получить только один корень");
                double D0 = (-b) / (2 * a);
                Console.WriteLine($"Корень такого уравнения = {D0}");
            }
            else
            {
                Console.WriteLine("Такое уравнение имеет два корня");
                double x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Первый корень уравнения = {x1}; Второй корень уравнения = {x2}");

            }
        }
    }
}
