using System;

namespace Задача4
{
    class Program
    {
        static int Perevod(int x)
        {
            return x < 2 ? x % 2 : (x % 2) + 10 * Perevod(x / 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число для перевода");
            int y,x;
            bool ok;
            do
            {
                Console.WriteLine("Введите число Х");
                string buf = Console.ReadLine();
                ok = Int32.TryParse(buf, out x);
                if ((!ok) || (x<=0))
                    Console.WriteLine("Ошибка");
            }
            while ((!ok) || (x <= 0));
            y = Perevod(x);
            Console.WriteLine("Число в двоичной системе счисления: {0}", y);
            Console.ReadKey();
        }
    }
}
