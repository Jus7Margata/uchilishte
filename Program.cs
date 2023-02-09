using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchilishte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете колко дни е работил в месеца: ");
            double dni1 = int.Parse(Console.ReadLine());

            Console.Write("Въведете колко пари изкарва на ден: ");
            double pariden = int.Parse(Console.ReadLine());

            Console.Write("Курс на долара спрямо ЛВ: ");
            double kurs = double.Parse(Console.ReadLine());

            double mesec = dni1 * pariden;
            double godina = (mesec * 12) + (mesec * 2.5);
            double danuk = godina / 4;
            double chistdohod = godina - danuk;
            double pechalba = chistdohod / 365;
            double pechalbalv = pechalba * kurs;

            Console.WriteLine("Средната печалба на ден е: " + Math.Round(pechalbalv, 2));

        }
    }
}
