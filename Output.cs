using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1._1
{
    class Output
    {
        public void OutputScreen()
        {
            PointFloat pointFloat = new PointFloat();
            pointFloat.ClassFloat();
            FloatStruct StructurFloat = new FloatStruct();
            StructurFloat.StructFloat();
            DoubleStruct StructurDouble = new DoubleStruct();
            StructurDouble.StructDouble();
            StructNoSqrt StructurNoSqrt = new StructNoSqrt();
            StructurNoSqrt.StructFloatNoSqrt();

        }
    }
}
