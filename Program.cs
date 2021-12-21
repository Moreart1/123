﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

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


            }
        }
    }
}
