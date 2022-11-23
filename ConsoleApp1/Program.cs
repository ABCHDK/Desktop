using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alg = new Algoritm(0, 1, 0.000001);
            Console.WriteLine($"Результат: [{alg.GetHalfDivine()}]\nИтераций: [{alg.IterCounter}]");            
            Console.ReadKey();
        }
    }
}
