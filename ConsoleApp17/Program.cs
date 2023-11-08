using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
       //9. Реализовать функцию возведения целого числа в квадрат 
        static void Sqr()
        {
            Console.Write("введ число для возвед в квадрат ");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Pow(x, 2);
            Console.WriteLine($"число {x} в квадрате {y}");
        }
        static void Main(string[] args)
        {
            Sqr();
            Console.ReadLine();
        }



    }
}
