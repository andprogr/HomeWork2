namespace Task4_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = Convert.ToInt32(Console.ReadLine());//проверить явл число степенью двойки
            int m;
            int k;
            do
            {
                m = d % 2;
                if (m == 0)
                    d /= 2;
               
            }
            while (m != 1);
            if ((m == 1) && (d > 2))
                Console.WriteLine("нет");
            else if ((m == 1) && (d == 1))
                Console.WriteLine("да");
            Console.ReadKey();
        }



    }
}
