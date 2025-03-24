namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++) //в массиве первые 5 по возрастанию, другие 5 по убыванию 
            {
                t[i] = rnd.Next(-51, 51);
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n - 6; i++)
            {
                for (int j = i + 1; j < n - 5; j++)
                {
                    if (t[i] > t[j])
                    {
                        int temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                    }

                }

            }
            for (int i = 5; i < n - 1; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    if (t[i] < t[k])
                    {
                        int temp2 = t[i];
                        t[i] = t[k];
                        t[k] = temp2;

                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", t[i]);
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }


}
