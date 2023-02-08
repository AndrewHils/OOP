using System;
using System.Linq;
namespace Lab1_5
{
    public class TOderedArray : TArray
    {
        public TOderedArray()
        {
            elements = null;
            number_e = 0;

        }
        public TOderedArray(int[] elem)
        {
            elements = elem;
            number_e = elements.Length;
            Array.Sort(elem);

        }
        public static TOderedArray operator +(TOderedArray arr, int b)
        {
            Array.Resize(ref arr.elements, arr.elements.Length + 1);
            arr.number_e++;
            arr.elements.SetValue(b, arr.elements.Length - 1);
            arr.Sort_Arr();
            return arr;
        }
        public static TOderedArray operator --(TOderedArray arr)
        {
            Array.Resize(ref arr.elements, arr.elements.Length - 1);
            arr.number_e--;
            arr.Sort_Arr();
            return arr;
        }
        public static TOderedArray operator *(TOderedArray arr, int b)
        {
            int count;
            for (int i = 0; i < arr.elements.Length; i++)
            {
                count = (int)arr.elements.GetValue(i);
                arr.elements.SetValue(count * b, i);
            }
            arr.Sort_Arr();
            return arr;
        }
        new public TOderedArray EnterArr()
        {
            int[] arr;
            int arr_l;
            int i = 0;
            int el;
            string input;

            Console.WriteLine("Введіть бажану довжину масиву");
            input = Console.ReadLine();

            arr_l = int.Parse(input);

            arr = new int[arr_l];

            for (int a = 0; a < arr_l; a++)
            {
                Console.WriteLine("Введіть елемент масиву :");
                input = Console.ReadLine();

                el = int.Parse(input);
                arr.SetValue(el, i);
                i++;
            }
            Console.WriteLine("Масив успішно заповнено!");

            TOderedArray Tarr = new TOderedArray(arr);

            return Tarr;
        }
    }
}
