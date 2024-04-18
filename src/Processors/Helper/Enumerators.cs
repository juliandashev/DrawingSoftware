using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Processors
{
    public static class Enumerators
    {
        public enum TriangleTypes
        {
            Equilateral, // равностранен
            Scalene, // равнобедрен
            Isosceles, // разностранен
            Acute, // остроъгълен
            Obtuse, // тъпоъгълен
            Right, // правоъгълен
            None
        }

        public enum SplineType
        {
            Bezier,
            Base,
            None
        }
    }
}
