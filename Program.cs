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
            Console.WriteLine("Введите 4,если хотите вывести двусвязный список");
            var vvod = Console.ReadLine();
            if (vvod == "1")
            {
                var block = new Block();
                block.Work();
            }
            else if (vvod == "2")
            {
                var fibo = new BezFibonachi();
                fibo.BFibonachi();
            }
            else if (vvod == "3")
            {
                var fiboRecursion = new RecFibonachi();
                fiboRecursion.RecursionFibonachi();
            }
            else if(vvod=="4")
            {
                var List = new DoubleLinkedList();
                Node newNode = List.FindNode(2);
                List.FindNode(5);
                List.AddNode(1);
                List.AddNodeAfter(newNode,3);
                List.GetCount();
                List.RemoveNode(3);
            }
        }

    }
}
