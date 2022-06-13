using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ObliczObjetoscKuli(10));

            Console.ReadLine();
        }
        //wzór na objętość kuli =  4/3 * PI (3,14) * promień (do potęgi 3)
        public static double ObliczObjetoscKuli(double promien)
        {
            return (double)(4.0 / 3.0) * 3.14 * Math.Pow(promien, 3);
        }
    }
}
