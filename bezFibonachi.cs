using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1._1
{
    class bezFibonachi
    {
        public void bFibonachi()
        {        
            Console.WriteLine("Какое колличество элементов формируемой последовательности выводить на консоль? ");
            int number = Convert.ToInt32(Console.ReadLine());
            int pervoeChislo = 1;
            Console.Write("{0} ", pervoeChislo);
            int vtoroeChislo = 1;
            Console.Write("{0} ", vtoroeChislo);
            int sum = 0;
            for (int i = 0; i < number-2; i++)
            {
                sum = pervoeChislo + vtoroeChislo;
                Console.Write("{0} ", sum);
                pervoeChislo = vtoroeChislo;
                vtoroeChislo = sum;
            }
           
        }
    }
}
