using System;
using System.IO;
using System.Net;

namespace iTool
{
    public class iNumber
    {
        /// <summary>
        /// Ask for number (for console).
        /// </summary>
        public static class AskNum
        {
            public static float AskFloat(string txt = "Enter number: ")
            {
                float num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToSingle(snum); }
                catch (Exception) { return AskFloat(txt); }
                return num;
            }
            public static Decimal AskDecimal(string txt = "Enter number: ")
            {
                Decimal num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToDecimal(snum); }
                catch (Exception) { return AskDecimal(txt); }
                return num;
            }
            public static Double AskDouble(string txt = "Enter number: ")
            {
                Double num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToDouble(snum); }
                catch (Exception) { return AskDouble(txt); }
                return num;
            }

            /// <summary>
            /// Ask for number. Type by default is Int32 or int.
            /// </summary>
            /// <returns></returns>
            public static Int32 Ask() { return Ask32(); }
            /// <summary>
            /// ask for number as integer and return an object. type = the given type.
            /// </summary>
            /// <typeparam name="NumType"></typeparam>
            /// <returns></returns>
            public static object Ask<NumType>()
            {
                Type tn = typeof(NumType);
                bool i16 = typeof(Int16) == tn;
                bool i32 = typeof(Int32) == tn;
                bool i64 = typeof(Int64) == tn;
                bool ui16 = typeof(UInt16) == tn;
                bool ui32 = typeof(UInt32) == tn;
                bool ui64 = typeof(UInt64) == tn;

                if (i16)
                    return (NumType)Convert.ChangeType(Ask16(), typeof(Int16));
                else
                if (i32)
                    return Ask32();
                else
                if (i64)
                    return Ask64();
                else
                if (ui16)
                    return AskU16();
                else
                if (ui32)
                    return AskU32();
                else
                if (ui64)
                    return AskU64();
                else
                    return null;
            }
            /// <summary>
            /// ask for int16
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static Int16 Ask16(string txt = "Enter number: ")
            {
                Int16 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToInt16(snum); }
                catch (Exception) { return Ask16(txt); }
                return num;
            }
            /// <summary>
            /// ask for int32
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static Int32 Ask32(string txt = "Enter number: ")
            {
                Int32 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToInt32(snum); }
                catch (Exception) { return Ask32(txt); }
                return num;
            }
            /// <summary>
            /// ask for int64
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static Int64 Ask64(string txt = "Enter number: ")
            {

                Int64 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToInt64(snum); }
                catch (Exception) { return Ask64(txt); }
                return num;
            }
            /// <summary>
            /// ask for uint64
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static UInt64 AskU64(string txt = "Enter number: ")
            {
                UInt64 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToUInt64(snum); }
                catch (Exception) { return AskU64(txt); }
                return num;
            }
            /// <summary>
            /// ask for uint32
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static UInt32 AskU32(string txt = "Enter number: ")
            {
                UInt32 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToUInt32(snum); }
                catch (Exception) { return AskU32(txt); }
                return num;
            }
            /// <summary>
            /// ask for uint16
            /// </summary>
            /// <param name="txt"></param>
            /// <returns></returns>
            public static UInt16 AskU16(string txt = "Enter number: ")
            {
                UInt16 num;
                string snum;
                Console.Write(txt);
                snum = Console.ReadLine();
                try { num = Convert.ToUInt16(snum); }
                catch (Exception) { return AskU16(txt); }
                return num;
            }
        }
    }
}