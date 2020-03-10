//namespace projekt_1

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Первая_попытка_С1
    // Реализовать функцию возведения в квадрат произведения двух вещественных чисел 

    {
        class Program
        {
            static void Main(string[] args)
            {
                double a, b, c;
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Math.Pow(a * b, 2);
                Console.WriteLine("c - " + c);
            }
        }
    }