using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using System.Reflection;
using System.IO;
using System.Runtime.Loader;


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
            Console.WriteLine("Введите 5,если хотите вывести расчет дистанции");
            Console.WriteLine("Введите 6,если хотите вывести поиск бинарного дерева");
            Console.WriteLine("Введите 7,если хотите реализовать  алгоритм задачи на количество вариантов и вывод количества вариантов для последовательности");
            var vvod = Console.ReadLine();
            if (vvod == "1")
            {
                var block = new Block();
                block.work();
            }
            else if (vvod == "2")
            {
                var fibo = new bezFibonachi();
                fibo.bFibonachi();
            }
            else if (vvod == "3")
            {
                var fiboRecursion = new recFibonachi();
                fiboRecursion.recursionFibonachi();
            }
            else if (vvod == "4")
            {
                var List = new DoubleLinkedList();
                List.AddNode(20);
                List.PrintList();
            }
            else if (vvod == "5")
            {
                Output output = new Output();
                output.OutputScreen();
                BenchmarkRunner.Run<Benchmark>();
            }
            else if (vvod=="6")
            {
                var tree = new BinaryTree();
                tree.Insert(20);
                tree.Insert(40);
                tree.Insert(10);
                tree.Insert(30);
                tree.Insert(80);
                tree.Insert(29);
                tree.Insert(31);
                tree.Insert(32);
                tree.Insert(70);
                BinaryTreeExtensions.Print(tree);
                tree.Remove(80);
                BinaryTreeExtensions.Print(tree);
                tree.Remove(29);
                BinaryTreeExtensions.Print(tree);

                SearchDFS ser = new SearchDFS(5);
                ser.Add(0, 1);
                ser.Add(0, 2);
                ser.Add(1, 1);
                ser.Add(1, 2);
                ser.Add(2, 0);
                ser.Add(2, 3);
                ser.Add(3, 4);
                Console.WriteLine("поиск в глубину");
                ser.DFSSer(2);

                SearchBFS sear = new SearchBFS(5);
                sear.Add(0, 1);
                sear.Add(0, 2);
                sear.Add(1, 1);
                sear.Add(1, 2);
                sear.Add(2, 0);
                sear.Add(2, 3);
                sear.Add(3, 4);
                Console.WriteLine("поиск в ширину");
                sear.BFS(2);

            }
            else if (vvod == "7")
            {
                var _Chess = new Chess();
                _Chess.Start();
            }
        }
    }
}
