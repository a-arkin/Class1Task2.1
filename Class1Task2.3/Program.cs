using System;

namespace Class1Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую точку первого отрезка");
            string LineFirstPointFirst0 = Console.ReadLine();
            int X10 = int.Parse(LineFirstPointFirst0);
            Console.WriteLine("Введите вторую точку первого отрезка");
            string LineFirstPointSecond0 = Console.ReadLine();
            int X11 = int.Parse(LineFirstPointSecond0);
            Console.WriteLine("Введите первую точку второго отрезка");
            string LineSecondPointFirst0 = Console.ReadLine();
            int X20 = int.Parse(LineSecondPointFirst0);
            Console.WriteLine("Введите вторую точку второго отрезка");
            string LineSecondPointSecond0 = Console.ReadLine();
            int X21 = int.Parse(LineSecondPointSecond0);
            if (X20 >= X10 && X20 <= X11|| X21>= X10&& X21<= X11)
            {
                Console.WriteLine("Отрезки пересекаются - True");
            }    
            else
            {
                Console.WriteLine("Отрезки не пересекаются - False");
            }
        }
    }
}
