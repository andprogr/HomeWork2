using System.Runtime.Intrinsics.Arm;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = 3;
            double b1 = 5;
            double c1 = 7;
            double a2 = 8;
            double b2 = 10;
            double c2 = 12;
           
            Console.WriteLine("S1={0}, S2={1}",CalculateArea(a1,b1,c1), CalculateArea(a2,b2,c2));
            if (CalculateArea(a1, b1, c1) > CalculateArea(a2, b2, c2))
                Console.WriteLine("площадь первого больше");
            else
                Console.WriteLine("площадь второго больше");
            Console.ReadKey();
        }
        static double CalculateArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
