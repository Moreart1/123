using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using AddFunction;

namespace ДЗ_1._1
{
    public struct DoubleStruct
    {
        public double X { get; set; }
        public double Y { get; set; }
        public DoubleStruct(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void StructDouble()
        {
            Console.WriteLine("                 PontDouble");
            int a = 10;
            int k = 10;
            double[] mas = new double[a];
            Random r = new Random();
            for (int i = 1; i < k; i++)
            {
                var PointStructDoubleA = new DoubleStruct(r.Next(1000), r.Next(1000));
                var PointStructDoubleB = new DoubleStruct(r.Next(1000), r.Next(1000));
                mas[i] = Math.Sqrt((PointStructDoubleA.X + PointStructDoubleB.X) + (PointStructDoubleA.Y + PointStructDoubleB.Y));
                Console.WriteLine(mas[i]);
            }
        }
        
    }
}
