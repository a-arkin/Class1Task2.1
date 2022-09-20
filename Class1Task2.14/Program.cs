using System;

namespace Class1Task2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            string NumberMonth0 = Console.ReadLine();
            int NumberMonth = int.Parse(NumberMonth0);
            switch (NumberMonth)
            {
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                case 12:
                    Console.WriteLine("Зима");
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное значение");
                    break;
            }
        }
    }
}
