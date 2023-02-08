using System;
using System.Linq;
namespace Lab1_5
{
    public class TArray
    {
        public int[] elements;
        public int number_e;

        public TArray()
        {
            elements = null;
            number_e = 0;
        }
        public TArray(int[] elem)
        {
            elements = elem;
            number_e = elements.Length;
        }
        public TArray EnterArr()
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

            TArray Tarr = new TArray(arr);

            return Tarr;
        }
        public void OutputArr()
        {
            Console.WriteLine("Ваш масив :");

            for (int i = 0; i < number_e; i++)
            {
                Console.WriteLine(elements.GetValue(i));
            }
        }
        public void Max_elem()
        {
            Console.WriteLine("Найбільший елемент масиву :");
            Console.WriteLine(elements.Max<int>());
        }
        public void Min_elem()
        {
            Console.WriteLine("Найменший елемент масиву :");
            Console.WriteLine(elements.Min<int>());
        }
        public void Sort_Arr()
        {
            //introspective sort

            Array.Sort(elements);

            Console.WriteLine("Масив успішно відсортовано!");

            OutputArr();
        }
        public void Sum_of_Arr(TArray arr)
        {
            int sum;

            sum = arr.elements.Sum();

            Console.WriteLine("Сума елементів Вашого масиву :");
            Console.WriteLine(sum);
        }
        public static TArray operator *(TArray arr, int b)
        {
            int count;
            for (int i = 0; i < arr.elements.Length; i++)
            {
                count = (int)arr.elements.GetValue(i);
                arr.elements.SetValue(count * b, i);
            }
            return arr;
        }
        public static TArray operator +(TArray arr, int b)
        {
            Array.Resize(ref arr.elements, arr.elements.Length + 1);
            arr.number_e++;
            arr.elements.SetValue(b, arr.elements.Length - 1);
            return arr;
        }
        public static TArray operator --(TArray arr)
        {
            Array.Resize(ref arr.elements, arr.elements.Length - 1);
            arr.number_e--;
            return arr;
        }
    }
}
