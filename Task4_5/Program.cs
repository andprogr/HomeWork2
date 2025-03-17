using System;

namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            do
            {
                Console.WriteLine("Введите число от 20 до 60");
                d = Convert.ToInt32(Console.ReadLine());
                if (d <= 60 && d >= 20) break;
            }
            while (true);
            Console.WriteLine("Число в диапазоне");
            Console.ReadLine();

        }
    }
}
