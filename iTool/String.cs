using System;
using System.IO;
using System.Net;

namespace iTool
{
    /* Todo 
     * probably overload for void methods that get string by ref
     * not static iString => creates a class as iString (like StringBuilder) ..
       probably inheriting from string builder ? or include others too (by using multiple classes) ?
    */
    public class iString
    {
        /// <summary>
        /// Convert to uppercase a char of the string with the given index.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string ToUpper(string str, int index) =>
            str.Substring(0, index) +
            str[index].ToString().ToUpper() +
            str.Substring(index + 1);
        /// <summary>
        /// Convert each first letter of every word to uppercase.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUpperEachFirstWord(string str)
        {
            var output = string.Empty;
            var arr = str.Split();
            foreach (var item in arr)
                output += ToUpper(item, 0) + " ";

            return output;
        }
        /// <summary>
        /// *For Console* Center the string (default: by window width)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Center(string str, bool ByBuffer = false)
        {
            int space;

            if (ByBuffer)
            {
                space = (Console.BufferWidth - str.Length) / 2;
                return Repeat(" ", space) + str;
            }
            else
            {
                space = (Console.WindowWidth - str.Length) / 2;
                return Repeat(" ", space) + str;
            }
        }
        /// <summary>
        /// Repeats given text for number of times.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Repeat(string text, int num)
        {
            string nm = "";
            for (int i = 0; i < num; i++) nm += text;
            return nm;
        }
        /// <summary>
        /// add zeroes at first of an integer.
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        public static string Zfill(int Number, int padding = 1)
        {
            string sn = Number.ToString();
            for (int i = 0; i < padding; i++) sn = "0" + sn;
            return sn;
        }
        /// <summary>
        /// Return string between the start & end strings from source string.
        /// </summary>
        /// <param name="strSource"></param>
        /// <param name="strStart"></param>
        /// <param name="strEnd"></param>
        /// <returns></returns>
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}