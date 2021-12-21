using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1._1
{
    class recFibonachi
    {
        public void recursionFibonachi()
        {
            {
        Console.WriteLine("Введите номер элемента последовательности Фибоначчи: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fib(n));
    }
    static int fib(int n)
    {
                if (n<2)
                {
                    return n;
                }
                return (fib(n - 1) + fib(n - 2));
    }
        }
    }
}
