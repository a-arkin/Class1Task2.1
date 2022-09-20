using System;

namespace Class1Task2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string FirstNumber0 = Console.ReadLine();
            double x0 = double.Parse(FirstNumber0);
            double x1 = x0 % 10;
            double x2 = x1 / 2;
            switch (x2)
                {
                    case 0:
                        Console.WriteLine("True");
                        break;
                    case 1:
                        Console.WriteLine("True");
                        break;
                    case 2:
                        Console.WriteLine("True");
                        break;
                    case 3:
                        Console.WriteLine("True");
                        break;
                    case 4:
                        Console.WriteLine("True");
                        break;
                    default:
                        Console.WriteLine("False");
                        break;
                }
        }
    }
}