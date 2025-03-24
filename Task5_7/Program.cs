namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] t = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) //в массиве элементы из диапазона и найти максимум
            {
                int max = 0;
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = rnd.Next(0,11);
                    if (t[i,j] > max)
                    {
                        max = t[i,j];
                       
                    }
                    Console.Write("{0,3} ", t[i, j]); //0,3 это количество позиций под элемент
                    
                }
                Console.WriteLine("{0,3} ", max);


            }

            Console.ReadKey();
        }
    }
}
