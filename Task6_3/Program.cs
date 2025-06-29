namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string mon = Console.ReadLine();
            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            Console.Write("Введите Сумма продаж: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Кол-во товаров: ");
            int item = Convert.ToInt32(Console.ReadLine());
            double sr = b / item;
            string resB = string.Format("{0:N2}", b);
            string resI = string.Format("{0:N0}", item);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Отчет о продажах за {0} {1}", mon,year);
            Console.WriteLine("Общая сумма продаж {0} р", resB);
            Console.WriteLine("Количество проданных товаров {0} шт", resI);
            Console.WriteLine("Средняя стоимость {0:f2} р", sr);
            Console.ReadKey();
        }
    }
}
