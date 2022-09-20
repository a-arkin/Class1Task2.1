using System;

namespace Class1Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string firstNumber0 = Console.ReadLine();
            double firstNimber = double.Parse(firstNumber0);
            Console.WriteLine("Введите второе число");
            string secondNumber0 = Console.ReadLine();
            double secondNumber = double.Parse(secondNumber0);
            Console.WriteLine("Введите третье число");
            string thirdNumber0 = Console.ReadLine();
            double thirdNumber = double.Parse(thirdNumber0);
            if(firstNimber> secondNumber&& firstNimber> thirdNumber)
            {
                Console.WriteLine($"Наибольшее число = {firstNimber}");
            }
            else if (secondNumber > firstNimber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"Наибольшее число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число = {thirdNumber}");
            }
        }   // Почему при выводе чисел на консоли через точку программа выдает ошибку?
    }       // При этом если ставить запятую, то все работает нормально
}
