using System;

namespace Class1Task2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string FirstNumber0 = Console.ReadLine();
            int x0 = int.Parse(FirstNumber0);
            Console.WriteLine("Введите первое число");
            string SecondNumber0 = Console.ReadLine();
            int x1 = int.Parse(SecondNumber0);
            Console.WriteLine("Введите первое число");
            string ThirdNumber0 = Console.ReadLine();
            int x2 = int.Parse(ThirdNumber0);
            if (x0>= x1&& x0<= x2)
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
