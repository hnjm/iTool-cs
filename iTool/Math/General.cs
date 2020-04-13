using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTool.iMath
{
    class General
    {
        /// <summary>
        /// Convert a deduction into percentage.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <param name="floor"></param>
        /// <param name="precise"></param>
        /// <returns></returns>
        public static decimal Percentage(long numerator, long denominator, bool floor = false, bool precise = false)
        {
            if (precise)
                if (floor)
                    return Math.Floor(Convert.ToDecimal((numerator * 100) / denominator));
                else
                    return Math.Ceiling(Convert.ToDecimal((numerator * 100) / denominator));
            else
                return Convert.ToDecimal((numerator * 100) / denominator);
        }
        /// <summary>
        /// Convert a deduction into percentage.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <param name="floor"></param>
        /// <param name="precise"></param>
        /// <returns></returns>
        public static decimal Percentage(double numerator, double denominator, bool floor = false, bool precise = false)
        {
            if (precise)
                if (floor)
                    return Math.Floor(Convert.ToDecimal((numerator * 100) / denominator));
                else
                    return Math.Ceiling(Convert.ToDecimal((numerator * 100) / denominator));
            else
                return Convert.ToDecimal((numerator * 100) / denominator);
        }
        static void x() { Console.WriteLine(""); }
    }
}
