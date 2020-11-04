using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько дней вы уже прожили:");
            string day = Console.ReadLine();
            Console.ReadKey();
           int a = Convert.ToInt32(day) / 365;
            Console.WriteLine(a); 
            int b = (Convert.ToInt32(day) % 365)/30;
            Console.WriteLine(b);

        }
    }
}
