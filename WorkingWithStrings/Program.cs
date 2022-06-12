using System;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiacSign;
            string placeOfWork;
            int age;

            Console.Write("Как вас зовут? : ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет? : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кто вы по знаку зодиака? : ");
            zodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете? : ");
            placeOfWork = Console.ReadLine();
            Console.WriteLine($"\nВас зовут {name} , вам {age} лет, вы {zodiacSign} и работаете {placeOfWork}");
        }
    }
}
