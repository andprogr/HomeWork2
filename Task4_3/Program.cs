namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());//расчет числа в степени
            int b = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            if (a>0&&b>0)
            
            {

                for (int i = 1; i <= b; i++)
                {
                    m *= a;
                }
                Console.WriteLine(m);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("введите a>0, b>0");
            }
            Console.ReadKey();
        }
    }
}
