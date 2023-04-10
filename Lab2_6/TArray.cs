using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab2_6.Scherbina
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

        ///////////////////////////////////////////
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
        public TArray AutoEnterArr()
        {
            int[] arr;
            int arr_l;
            int i = 0;
            int el;
            string input;
            int l_bound_rand;
            int u_bound_rand;

            var rand = new Random();

            Console.WriteLine("Введіть бажану довжину масиву");
            input = Console.ReadLine();

            arr_l = int.Parse(input);

            arr = new int[arr_l];

            Console.WriteLine("Введіть мінімальний єлемент");
            input = Console.ReadLine();
            l_bound_rand = int.Parse(input);

            Console.WriteLine("Введіть максимальний єлемент");
            input = Console.ReadLine();
            u_bound_rand = int.Parse(input);

            for (int a = 0; a < arr_l; a++)
            {
                el = rand.Next(l_bound_rand, u_bound_rand);
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
                Console.Write(elements.GetValue(i) + " ");
            }
            Console.WriteLine(";");
        }

        //////////////////////////////////////
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
        public void Sum_of_Arr(TArray arr)
        {
            int sum;

            sum = arr.elements.Sum();

            Console.WriteLine("Сума елементів Вашого масиву :");
            Console.WriteLine(sum);
        }

        ////////////////////////////////////////////////
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
        //////////////////////////////////////////////////////
        public int[] Del(int[] data, int value)
        {
            int index;

            List<int> tmp = new List<int>(data);

            index = BinarySearch(data, value);

            if (index < 0 || index >= data.Length)
            {
                Console.WriteLine("Індекс за межами масиву");

                return data;
            }

            tmp.RemoveAt(index);

            data = tmp.ToArray();

            Console.WriteLine("Число успішно видалено!");

            number_e--;

            return data;
        }
        /////////////////////////////////////////////////////////////////

        public int[] Insert(int[] arr, int value, int index)
        {
            int[] tmp = new int[arr.Length + 1];

            tmp[index] = value;

            for (int i = 0; i < index; i++)
                tmp[i] = arr[i];

            for (int i = index; i < arr.Length; i++)
                tmp[i + 1] = arr[i];

            Array.Resize(ref arr, arr.Length + 1);
            number_e++;

            arr = tmp;

            Console.WriteLine("Число успішно додано до масиву!");

            return arr;
        }
        ////////////////////////////////////////////////////////////////

        public int[] Task1(int[] arr)
        {
            float evrage;
            int sum;

            sum = arr.Sum();

            evrage = sum / arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > evrage)
                {
                    arr[i] = 0;
                }
                else
                {
                    i++;
                }
            }
            return arr;
        }
        public void Task2()
        {
            TArray A = new TArray();
            TArray B = new TArray();
            TArray C = new TArray();

            A = A.AutoEnterArr();
            B = B.AutoEnterArr();

            if (A.elements.Length > B.elements.Length)
            {
                Array.Resize(ref B.elements, A.elements.Length);
                B.number_e = A.number_e;
            }
            else
            {
                Array.Resize(ref A.elements, B.elements.Length);
                A.number_e = B.number_e;
            }

            A.Sort_Arr();
            B.Sort_Arr();

            int[] tmp = new int[B.elements.Length];
            Array.Resize(ref C.elements, B.elements.Length);
            C.number_e = B.number_e;

            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = A.elements[i] * B.elements[i];
                tmp[i] *= 2;
            }

            B *= 3;

            for (int i = 0; i < tmp.Length; i++)
            {
                C.elements[i] = tmp[i] - B.elements[i];
            }
            C.OutputArr();
        }
        public int[] Task3_1(int[] arr, int lower_b, int upper_b)
        {
            int[] tmp = new int[arr.Length];
            int k = 0;

            for (int i = 0; i < lower_b; i++)
                tmp[i] = arr[i];

            for (int i = upper_b; i < arr.Length; i++)
                tmp[i] = arr[i];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] != 0)
                {
                    tmp[k] = tmp[i];
                    k++;
                }
            }

            for (int i = k; i < tmp.Length; i++)
                tmp[i] = 0;

            return tmp;
        }
        public int[] Task3_2(int[] arr, int lower_b, int upper_b)
        {
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= lower_b && arr[i] <= upper_b)
                {
                    arr[i] = 0;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[k] = arr[i];
                    k++;
                }
            }

            for (int i = k; i < arr.Length; i++)
                arr[i] = 0;

            return arr;
        }
        ///////////////////////////////////////// СОРТУВАННЯ //////////////////
        public void Sort_Arr()
        {
            //introspective sort

            Array.Sort(elements);

            Console.WriteLine("Масив успішно відсортовано!");

            OutputArr();
        }
        /////// ШВИДКЕ СОРТУВАННЯ /////
        public static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        public static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        public int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        ////////////////////////////////////// ПОШУК //////////////////////////
        public int BinarySearch(int[] data, int value)
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
    }
}
