namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;//проверить явл число степенью двойки
            do
            {
                Console.WriteLine("Введите число");
                d = Convert.ToInt32(Console.ReadLine());
                if ((d& (d - 1)) == 0) break;//это степень двойки НЕ ПОЛУЧИЛОСЬ
            }
            while (true);
            Console.WriteLine("да");
            Console.ReadLine();
        }
    }
}
