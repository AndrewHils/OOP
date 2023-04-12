using System;
namespace Sort
{
    class MySorts
    {
        /////// ШВИДКЕ СОРТУВАННЯ (ХОРА)/////
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
        static public int[] QuickSort(int[] array, int minIndex, int maxIndex)
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

        static public int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        //////////////////////////////////////////////////////////
        ///
        /////////////////// ПІРАМІДАЛЬНЕ СОРТУВАННЯ ////////////////
        static public void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // левый = 2*i + 1
            int r = 2 * i + 2; // правый = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                Heapify(arr, n, largest);
            }
        }

        // Основная функция, выполняющая пирамидальную сортировку
        static public void HeapSort(int[] arr, int n)
        {
            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Один за другим извлекаем элементы из кучи
            for (int i = n - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                Swap(ref arr[0], ref arr[i]);

                // вызываем процедуру heapify на уменьшенной куче
                Heapify(arr, i, 0);
            }
        }
        ///////////////////////////////////////////////////////////
        ///
        ////////////////////// СОРТУВАННЯ ШЕЛЛА ///////////////////////

        static public int[] ShellSort(int[] array)
        {
            //відстань між елементами, які порівнюються
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }

        ///////////////////////////////////////////////////////////////////
        ///
        //////////////////// СОРТУВАННЯ БУЛЬБАШКОЮ //////////////////////////
        static public int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        //////////////////////////////////////////////////////////////////////////
        ///
        //////////////////////// СОРТУВАННЯ ВКЛЮЧЕННЯМИ/////////////////////////
        static public int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }
        /////////////////////////////////////////////////////////////////////////
        ///
        //////////////////////////СОРТУВАННЯ ВИБОРОМ/////////////////////////////
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }
        static public int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }

            return SelectionSort(array, currentIndex + 1);
        }

    }
}
