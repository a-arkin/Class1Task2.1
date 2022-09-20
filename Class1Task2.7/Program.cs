using System;

namespace Class1Task2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число");
            string FirstNumber0 = Console.ReadLine();
            int FirstNumber = int.Parse(FirstNumber0);
            int x0 = FirstNumber % 10;
            int x1 = (FirstNumber/10) % 10;
            int x2 = (FirstNumber / 100) % 10;
            int x3 = (FirstNumber / 1000) % 10;
            int x4 = (FirstNumber / 10000) % 10;
            int x5 = (FirstNumber / 100000) % 10;
            if(x0+ x1 + x2 == x3+ x4 + x5)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
