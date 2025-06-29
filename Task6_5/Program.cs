using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ph =
            {
                "4991234567", 
                "+7(123)456-78-90",
                "+7(123)4567890",
                "8(900)098-87-65", 
                "+79005678990",
                "79005678990"
            };
            string pattern = @"^\+7\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$";
            Regex regex=new Regex(pattern);
            foreach (string s in ph)
            {
                if (regex.IsMatch(s))
                    Console.WriteLine("{0} - yes",s);
                else Console.WriteLine("{0} - no", s);
            }

            Console.ReadKey();
            
        }
    }
}
