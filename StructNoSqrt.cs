using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddFunction;

namespace ДЗ_1._1
{
    public struct StructNoSqrt
    {
        public float X { get; set; }
        public float Y { get; set; }
        public StructNoSqrt(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void StructFloatNoSqrt()
        {
            Console.WriteLine("                 PontFloat");
            int o = 20;
            int j = 20;
            double[] array = new double[o];
            Random r = new Random();
            for (int i = 1; i < j; i++)
            {
                var PointFloatA = new StructNoSqrt(r.Next(1000), r.Next(1000));
                var PointFloatB = new StructNoSqrt(r.Next(1000), r.Next(1000));
                array[i] = ((PointFloatA.X + PointFloatB.X) + (PointFloatA.Y + PointFloatB.Y));
                Console.WriteLine(array[i]);
            }
        }
    }
}
