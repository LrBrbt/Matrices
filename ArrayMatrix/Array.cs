using System;

namespace ArrayMatrix
{
    public class Array
    {
        public class ForArray
        {
            static public int[] Create(int size)
            {
                return new int[size];
            }
            static public void Fill(int[] array, int minValue, int maxValue)
            {
                Random random = new();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(minValue, maxValue);
                }
            }


        }
    }
}
