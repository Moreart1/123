using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using AddFunction;

namespace ДЗ_1._1
{
    public struct FloatStruct
    {

        public float X { get; set; }
        public float Y { get; set; }
        public FloatStruct(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void StructFloat()
        {
            Console.WriteLine("                 PontStruct");
            int a = 10;
            int k = 10;
            float[] mas = new float[a];
            Random r = new Random();
            for (int i = 1; i < k; i++)
            {
                var PointStructFloatA = new FloatStruct(r.Next(1000), r.Next(1000));
                var PointStructFloatB = new FloatStruct(r.Next(1000), r.Next(1000));
                mas[i] = (float)Math.Sqrt((PointStructFloatA.X + PointStructFloatB.X) + (PointStructFloatA.Y + PointStructFloatB.Y));
                Console.WriteLine(mas[i]);
            }
        }

    }
}
