using System;

namespace Class1Task2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string FirstNumber0 = Console.ReadLine();
            int x = int.Parse(FirstNumber0);
            if (x>=0)
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
