using System;

namespace iTool
{
    class iArray
    {
        public static void Init<Arr>(ref Arr[] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(array.Length));
            for (int x = 0; x < length; x++)
            {
                array[x] = value;
            }
        }
        public static void Init2D<Arr>(ref Arr[,] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(array.Length));
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    array[x, y] = value;
                }
            }
        }
        public static void Init3D<Arr>(ref Arr[,,] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(Math.Sqrt(array.Length)));
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    for (int z = 0; z < length; z++)
                    {
                        array[x, y, z] = value;
                    }
                }
            }
        }
        public static Arr[] Init<Arr>(Arr[] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(array.Length));
            for (int x = 0; x < length; x++)
            {
                array[x] = value;
            }
            return array;
        }
        public static Arr[,] Init2D<Arr>(Arr[,] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(array.Length));
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    array[x, y] = value;
                }
            }
            return array;
        }
        public static Arr[,,] Init3D<Arr>(Arr[,,] array, Arr value)
        {
            int length = Convert.ToInt32(Math.Sqrt(Math.Sqrt(array.Length)));
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    for (int z = 0; z < length; z++)
                    {
                        array[x, y, z] = value;
                    }
                }
            }
            return array;
        }
    }
}
