using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1,если хотите вывести на экран алгоритм проверки, простое число или нет.");

            Console.WriteLine("Введите 2,если хотите вывести на экран функцию вычисления числа Фибоначчи без рекурсии");

            Console.WriteLine("Введите 3,если хотите вывести на экран функцию вычисления числа Фибоначчи с помощью рекурсии");
            var  vvod = Console.ReadLine();
            if (vvod =="1")
            {
                var block = new Block();
                block.work();
            }
            else if (vvod =="2")
            {
                var fibo = new bezFibonachi();
                fibo.bFibonachi();
            }
            else if (vvod =="3")
            {
                var fiboRecursion = new recFibonachi();
                fiboRecursion.recursionFibonachi();
            }
        }
       
    }
}
