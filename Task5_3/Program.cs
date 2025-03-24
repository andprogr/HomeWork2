namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int max = 0;
            int min = 10;
            int maxindex = 0;
            int minindex = 0;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) //в массиве вывести значение макс и минимального и их индексы
            {
                t[i] = rnd.Next(0, 11);
                if (t[i] > max)
                {
                    max = t[i];
                    maxindex = i;

                }
                if (t[i] <min)
                {
                    min = t[i];
                    minindex = i;
                }

                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Индекс максимума=" + maxindex);
            Console.WriteLine("Индекс минимума=" + minindex);

            //Console.WriteLine(max);
            //Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
