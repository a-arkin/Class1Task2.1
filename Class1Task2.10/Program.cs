using System;

namespace Class1Task2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            string FirstNumber0 = Console.ReadLine();
            int x0 = int.Parse(FirstNumber0);
            int x1 = x0 % 10;
            int x2 = (x0 / 10) % 10;
            if (x1>x2)
            {
                Console.WriteLine($"{x1}");
            }
            else
            {
                Console.WriteLine($"{x2}");
            }
        }
    }
}
