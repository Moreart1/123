using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using AddFunction;

namespace ДЗ_1._1
{
    public class Benchmark
    {
        [Benchmark]
        public void Class_Float()
        {
            PointFloat pointFloat = new PointFloat();
            pointFloat.ClassFloat();
        }
        [Benchmark]
        public void StructFloat()
        {
            FloatStruct StructurFloat = new FloatStruct();
            StructurFloat.StructFloat();
        }
        [Benchmark]
        public void StructDouble()
        {
            DoubleStruct StructurDouble = new DoubleStruct();
            StructurDouble.StructDouble();
        }
        [Benchmark]
        public void StructurNoSqrt()
        {
            StructNoSqrt StructurNoSqrt = new StructNoSqrt();
            StructurNoSqrt.StructFloatNoSqrt();
        }

    }
}

