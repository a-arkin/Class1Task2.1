using System;

namespace Class1Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            string FirstNumber0 = Console.ReadLine();
            int FirstNumber = int.Parse(FirstNumber0);
            if(FirstNumber>9)
            {
                int x0 = FirstNumber % 10;
                int x1 = (FirstNumber / 10) % 10;
                Console.WriteLine($"{x0}{x1}");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
