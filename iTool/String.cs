using System;
using System.IO;
using System.Net;

namespace iTool
{
    public static class iString
    {
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
        private static string GetBetween(string strSource, string strStart, string strEnd)
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