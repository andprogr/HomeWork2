using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя: ");
            string n = Console.ReadLine();
            Console.Write("Возраст: ");
            string a = Console.ReadLine();
            Console.Write("Город: ");
            string g = Console.ReadLine();
            StringBuilder sb = new StringBuilder("Имя:");
            sb.Append(n);
            StringBuilder sb1 = new StringBuilder("Возраст:");
            sb1.Append(a);
            StringBuilder sb2 = new StringBuilder("Город:");
            sb2.Append(g);
            Console.Write($"{sb} {sb1} {sb2}");
            Console.ReadKey();
        }
    }
}
