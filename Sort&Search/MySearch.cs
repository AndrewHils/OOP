using System;
namespace Sort
{
    class MySearch
    {
        ///////////////////////БІНАРНИЙ ПОШУК //////////////////////////
        public static int BinarySearch(int[] data, int value)
        {
            var left = data.GetLowerBound(0);
            var right = data.GetUpperBound(0);
            if (left == right)
                return left;
            while (true)
            {
                if (right - left == 1)
                {
                    if (data[left].CompareTo(value) == 0)
                        return left;
                    if (data[right].CompareTo(value) == 0)
                        return right;
                    return -1;
                }
                else
                {
                    var middle = left + (right - left) / 2;
                    var comparisonResult = data[middle].CompareTo(value);
                    if (comparisonResult == 0)
                        return middle;
                    if (comparisonResult < 0)
                        left = middle;
                    if (comparisonResult > 0)
                        right = middle;
                }
            }
        }
        //////////////////////////////////////////////////////////////////
        ///
        //////////////////// ЛІНІЙНИЙ ПОШУК //////////////////////////////
        ///
        static public int LіnSearch(int[] M, int key)
        {
            for (int i = 0; i < M.Length; i++)
            {
                if (key == M[i])
                {
                    return i;
                }
            }
            return -1;
        }
        //////////////////////////////////////////////////////////////////
        ///
        //////////////////// ЛІНІЙНИЙ ПОШУК З БАРЬЕРОМ //////////////////////////////
        static public int LіnSearchQuіck(int[] M, int key)
        {
            int і = 0;

            while (M[і].CompareTo(key) != 0) і++;

            if (і == M.Length + 1) return -1; else return і;
        }
        //////////////////////////////////////////////////////////////////
        ///
        //////////////////// ПОШУК З ТРАНСПОЗИЦІЄЮ //////////////////////////////
        static public int Search(int[] f_a, int f_element, int f_size)
        {
            int f_index = -1;

            for (int i = 0; i < f_size; i++)
            {
                if (f_a[i] == f_element)
                {
                    f_index = i;

                    if (f_index == 0)
                    {
                        break;
                    }
                    else
                    {
                        Swap(ref f_a[i], ref f_a[i - 1]);
                    }
                }
            }

            return f_index;
        }
        public static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}
