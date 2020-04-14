using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace iTool.Network
{
    class iPing
    {
        public struct PingTypes
        {
            public long Time;
            public bool pingable;
            public byte[] buffer;
            public IPStatus IPstatus;
        }
        /// <summary>
        /// Pings the given address once.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static PingTypes Ping(string Address, int timeout = 2500)
        {
            var pinger = new Ping();
            var pingTypes = new PingTypes();
            try
            {
                PingReply reply = pinger.Send(Address, timeout);

                pingTypes.Time = reply.RoundtripTime;
                pingTypes.buffer = reply.Buffer;
                pingTypes.IPstatus = reply.Status;
                pingTypes.pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException) { } // Discard PingExceptions and return false; 
            finally
            {
                if (pinger != null)
                    pinger.Dispose();
            }

            //return pingable;
            return pingTypes;
        }
        /// <summary>
        /// Pings the given address once.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static PingTypes Ping(IPAddress Address, int timeout = 2500)
        {
            var pinger = new Ping();
            var pingTypes = new PingTypes();
            try
            {
                PingReply reply = pinger.Send(Address, timeout);

                pingTypes.Time = reply.RoundtripTime;
                pingTypes.buffer = reply.Buffer;
                pingTypes.IPstatus = reply.Status;
                pingTypes.pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException) { } // Discard PingExceptions and return false; 
            finally
            {
                if (pinger != null)
                    pinger.Dispose();
            }

            //return pingable;
            return pingTypes;
        }
        /// <summary>
        /// Archives an array of pings to the given address.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public static PingTypes[] Pings(string Address, int timeout = 2500, ushort times = 2)
        {
            if (times > 0)
            {
                var pings = new PingTypes[times];

                for (int i = 0; i < times; i++)
                    pings[i] = Ping(Address, timeout);

                return pings;
            }
            else
                return null;
        }
        /// <summary>
        /// Archives an array of pings to the given address.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public static PingTypes[] Pings(IPAddress Address, int timeout = 2500, ushort times = 2)
        {
            if (times > 0)
            {
                var pings = new PingTypes[times];

                for (int i = 0; i < times; i++)
                    pings[i] = Ping(Address, timeout);

                return pings;
            }
            else
                return null;
        }
        /// <summary>
        /// Calculates the total of round trip time of pings.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public static long PingTotalTime(string Address, int timeout = 2500, ushort times = 2)
        {
            if (times > 0)
            {
                long[] tripTimesArr = new long[times];

                for (int i = 0; i < times; i++)
                    tripTimesArr[i] = Ping(Address, timeout).Time;

                return tripTimesArr.Sum() / tripTimesArr.Length;
            }
            else
                return -1;
        }
        /// <summary>
        /// Calculates the total of round trip time of pings.
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="timeout"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public static long PingTotalTime(IPAddress Address, int timeout = 2500, ushort times = 2)
        {
            if (times > 0)
            {
                long[] tripTimesArr = new long[times];

                for (int i = 0; i < times; i++)
                    tripTimesArr[i] = Ping(Address, timeout).Time;

                return tripTimesArr.Sum() / tripTimesArr.Length;
            }
            else
                return -1;
        }
    }
}