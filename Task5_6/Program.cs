namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] t = new int[n, n];

            for (int i = 0; i < n; i++) //в массиве элементы в шахматном порядке
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = 1-(i+j)%2;
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();


            }

            Console.ReadKey();
        }
    }
}
