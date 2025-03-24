namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 100;
            int[] t = new int[n];
            Random rnd = new Random();

            int c = 0;
            int nc = 0;
            for (int i = 0; i < n; i++) //в массиве подсчет четн и нечетных и сравнение
            {
                t[i] = rnd.Next(0, 101);
                if ((t[i] % 2) == 0)
                {
                    c++;
                }
                else nc++;
                    Console.Write("{0}", t[i]);
                
            }
            Console.WriteLine();
            if (c > nc)
            {
                Console.WriteLine("Четных больше" +c);
            }
            if (c < nc)
            {
                Console.WriteLine("Нечетных больше" + nc);
            }
            if (c== nc)
                Console.WriteLine("Поровну");
           
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(nc);
            Console.ReadKey();
        }
    }
}
