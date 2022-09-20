using System;

namespace Class1Task2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите Ваш пол (м/ж)");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            string age0 = Console.ReadLine();
            int age = int.Parse(age0);
            string genderM = "м";
            if (age<14)
            {
                Console.WriteLine($"Увы, {Name}, наш ресурс доступен для людей старше 14 лет");
            }
            else if (gender== genderM)
            {
                Console.WriteLine($"Дорогой, {Name}, добро пожаловать на наш ресурс!");
            }
            else
            {
                Console.WriteLine($"Дорогая, {Name}, добро пожаловать на наш ресурс");
            }
        }
    }
}
