using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using AddFunction;

namespace ДЗ_1._1
{
    class PointFloat
    {
        public PointFloat()
        {
        }
        public float X { get; set; }
        public float Y { get; set; }
        public PointFloat(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void ClassFloat()
        {
            Console.WriteLine("                 PontFloat");
            int a = 10;
            int k = 10;
            double[] mas = new double[a];
            Random r = new Random();
            for (int i = 1; i < k; i++)
            {
                var PointFloatA = new PointFloat(r.Next(1000), r.Next(1000));
                var PointFloatB = new PointFloat(r.Next(1000), r.Next(1000));
                mas[i] = Math.Sqrt((PointFloatA.X + PointFloatB.X) + (PointFloatA.Y + PointFloatB.Y));
                Console.WriteLine(mas[i]);
            }
        }
    }

}
