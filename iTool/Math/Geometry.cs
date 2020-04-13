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
                public static double Diameter(double Radius) => 2 * Radius;
                public static double Area(double Radius) => Math.PI * System.Math.Pow(Radius, 2);
                public static double Circumference(double Radius, bool doit = true) => Math.PI * (Radius * 2);
                public static double Circumference(double Diameter) => Math.PI * Diameter;
            }
            public class Square
            {
                public static double Area(double Side) => Side * Side;
                public static double Perimiter(double Side) => Side * 4;
            }
            public class Rectangle
            {
                public static double Area(double side1, double side2) => side1 * side2;
                public static double Perimiter(double side1, double side2) => (2 * side1) + (side2 * 2);
            }
            public class Triangle { }
        }
    }
}
