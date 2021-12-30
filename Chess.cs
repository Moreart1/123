using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Loader;
using Microsoft.Extensions.DependencyModel;
using System.IO;

namespace ДЗ_1._1
{
    class Chess
    {
        const int RowCount = 8;
        const int ColCount = 8;
        private int[,] _desk = new int[RowCount, ColCount];

        public void Start()
        {
            for (int i = 0; i < RowCount; i++)
                _desk[i, 0] = 1;
            for (int j = 0; j < RowCount; j++)
                _desk[0, j] = 1;

            for (int i = 1; i < RowCount; i++)
                for (int j = 1; j < RowCount; j++)
                    _desk[i, j] = _desk[i - 1, j] + _desk[i, j - 1];

            PrintDesk();
        }

        private void PrintDesk()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                    Console.Write($" \t{_desk[i, j]}");
                Console.WriteLine();


            }
        }

    }
}

