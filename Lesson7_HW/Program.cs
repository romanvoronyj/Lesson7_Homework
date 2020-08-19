using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HW
{
    class Program
    {
        static void Calculate (ref double numOne, ref double numTwo, ref double numThree, out double resultFromOne, out double resultFromTwo, out double resultFromThree)
        {
            resultFromOne = numOne / 5;
            Console.WriteLine("Результат ділення числа {0} на 5 дорівнює {1}.", numOne, resultFromOne);
            resultFromTwo = numTwo / 5;
            Console.WriteLine("Результат ділення числа {0} на 5 дорівнює {1}.", numTwo, resultFromTwo);
            resultFromThree = numThree / 5;
            Console.WriteLine("Результат ділення числа {0} на 5 дорівнює {1}.", numThree, resultFromThree);


        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть 1-е ціле число:");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введіть 1-е ціле число:");
            double y = Double.Parse(Console.ReadLine());
            Console.Write("Введіть 1-е ціле число:");
            double z = Double.Parse(Console.ReadLine());
            double result1;
            double result2;
            double result3;

            Calculate(ref x, ref y, ref z, out result1, out result2, out result3);
            Console.ReadKey();

        }
    }
}
