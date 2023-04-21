using System;
using System.Collections.Generic;
namespace Lab8_4
{
    public class FileText
    {
        static public int CountUpArr(char[] arr)
        {
            int result = 0;

            foreach (var item in arr)
            {
                if (Char.IsUpper(item) == true)
                {
                    result++;
                }
            }

            return result;
        }
        static public int CountUpList(List<char> arr)
        {
            int result = 0;

            foreach (var item in arr)
            {
                if (Char.IsUpper(item) == true)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
