using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ArraySearch

    {
        static void Main()
        {
            Console.WriteLine("Введите сумму вклада(руб.) и процент");
            double vklad = Convert.ToDouble(Console.ReadLine());
            int procent = Convert.ToInt32(Console.ReadLine());
            double value = Discount(vklad, procent);
            Console.WriteLine("Сумма процента: " + value);

        }

        public static double Discount (double vklad, int procent)
        {
                if (procent <= 0 || procent > 32)
                return  0;
                else
                return (vklad * procent / 100);
           
        }
    }
}
