using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
         double i=1;
         while (n >= 1)
         {
             i *= n;
             n -= 2;
         }
         Console.WriteLine($"Dvaynoy factoriak raven {i}");
        }
    }
}