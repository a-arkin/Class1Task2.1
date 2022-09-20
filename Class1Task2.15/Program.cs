using System;

namespace Class1Task2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            string FirstNumber0 = Console.ReadLine();
            int x0 = int.Parse(FirstNumber0);
            Console.WriteLine("Введите второе значение");
            string SecondNumber0 = Console.ReadLine();
            int x1 = int.Parse(SecondNumber0);
            Console.WriteLine("Введите символ операции");
            string symbol = Console.ReadLine();
            char x2 = char.Parse(symbol);
            switch (x2)
            {
                case '+':
                    int sum = x0 + x1;
                    Console.WriteLine(sum);
                    break;
                case '-':
                    int difference = x0 - x1;
                    Console.WriteLine(difference);
                    break;
                case '*':
                    int multiplication = x0 * x1;
                    Console.WriteLine(multiplication);
                    break;
                case '/':
                    int fraction = x0 / x1;
                    Console.WriteLine(fraction);
                    break;
            }
        }
    }
}
