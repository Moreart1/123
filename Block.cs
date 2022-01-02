using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddFunction;

namespace ДЗ_1._1
{
    class Block
    {
      public  void work()
        {
            int n;
            Console.WriteLine("Введите число для определения,простое оно или составное");
            n = Int32.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            
        }


    }
}

