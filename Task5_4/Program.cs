namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++) //в массиве перевернуть элементы
            {
                t[i] = rnd.Next(0, 11);


                Console.Write("{0} ", t[i]);
                // t[i] += t[n - 1 - i];

            }
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--) //в массиве перевернуть элементы
            {
                //t[i] = n - 1;


                Console.Write("{0} ", t[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

