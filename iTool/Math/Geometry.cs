using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTool.iMath
{
    public class iGeometry
    {
        public class _2D
        {
            public class Circle
            {
                public static double Diameter(double Radius) { return 2 * Radius; }
                public static double Area(double Radius)
                {
                    return System.Math.PI * System.Math.Pow(Radius, 2);
                }
                public static double Circumference(double Radius, bool doit = true)
                {
                    return System.Math.PI * (Radius * 2);
                }
                public static double Circumference(double Diameter)
                {
                    return System.Math.PI * Diameter;
                }
            }
            public class Square
            {
                public static double Area(double Side) { return Side * Side; }
                public static double Perimiter(double Side) { return Side * 4; }
            }
            public class Rectangle
            {
                public static double Area(double side1, double side2)
                {
                    return side1 * side2;
                }
                public static double Perimiter(double side1, double side2)
                {
                    return (2 * side1) + (side2 * 2);
                }
            }
            public class Triangle { }
        }
    }
}
