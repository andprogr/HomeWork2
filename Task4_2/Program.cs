namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//расчет суммы дробей 1делить на n
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s+=(1.0)/i;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
