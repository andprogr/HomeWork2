namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 40;
            int[] t = new int[n];
            Random rnd = new Random();

            int c = 0;// положительные
            int nc = 0;//отрицательные
            int o = 0;//нули
            for (int i = 0; i < n; i++) //в массиве подсчет положительных и отриц-х
            {
                t[i] = rnd.Next(-20, 21);
                if ((t[i] > 0))
                {
                    c++;
                }
                if ((t[i] < 0))
                {
                    nc++;
                }
                if ((t[i] == 0))
                {
                    o++;
                }

                Console.Write("{0}  ", t[i]);

            }
            Console.WriteLine();

            Console.WriteLine("Положит" + c);

            Console.WriteLine("Отрицат" + nc);
            Console.WriteLine("Нули" + o);

            //Console.WriteLine("Поровну");

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(nc);
            Console.ReadKey();
        }
    }
}
