using System.Globalization;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//расчет факториала
            int m = 1;
            for (int i = 1; i <= n; i++)
            {
                m=m*i;
            }
           
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
