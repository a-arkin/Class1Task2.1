using System;

namespace Class1Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            string firstNumber0 = Console.ReadLine();
            int firstNimber = int.Parse(firstNumber0);
            Console.WriteLine("Введите второе целое число");
            string secondNumber0 = Console.ReadLine();
            int secondNumber = int.Parse(secondNumber0);
            if(firstNimber> secondNumber)
            {
                Console.WriteLine($"Первое значение больше второго. Минимальное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Второе значение больше первого. Минимальное число = {firstNimber}");
            }
        }
    }
}
