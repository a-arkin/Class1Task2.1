using System;

namespace Class1Task2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            string FirstNumber0 = Console.ReadLine();
            int FirstNumber = int.Parse(FirstNumber0);
            if (FirstNumber > 999)
            {
                int x0 = FirstNumber % 10;
                int x1 = (FirstNumber / 10) % 10;
                int x2 = (FirstNumber / 100) % 10;
                int x3 = (FirstNumber / 1000) % 10;
                Console.WriteLine($"{x0}{x1}{x2}{x3}");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
