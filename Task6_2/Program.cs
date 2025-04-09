using System;
using System.Reflection.Metadata.Ecma335;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            str = str.Replace(" ",String.Empty);
            str = str.ToLower();
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            if (str.CompareTo(reverseString)==0)
                    {
                      Console.WriteLine("Полином");
                    }
            else
            {
                Console.WriteLine("Не полином");
            }    
                
           
            Console.ReadLine();
        }
    }
}
