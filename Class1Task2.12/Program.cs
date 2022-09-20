using System;

namespace Class1Task2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели (вводить с заглавной буквы");
            string day0 = Console.ReadLine();
            switch (day0)
            {
                case "Суббота":
                    Console.WriteLine("Сегодня выходной");
                    break;
                case "суббота":
                    Console.WriteLine("Сегодня выходной");
                    break;
                case "Воскресенье":
                    Console.WriteLine("Сегодня выходной");
                    break;
                case "воскресенье":
                    Console.WriteLine("Сегодня выходной");
                    break;
                case "Пятница":
                    Console.WriteLine("Ура! Пятничка!");
                    break;
                case "пятница":
                    Console.WriteLine("Ура! Пятничка!");
                    break;
                default:
                    Console.WriteLine("Будний день");
                    break;
            }
        }
    }
}
