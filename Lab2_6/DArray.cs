using System;
namespace Lab2_6.Scherbina
{
    public class DArray : TArray
    {
        public int[,] arr;
        public int rows;
        public int columns;

        public DArray()
        {
            arr = new int[0, 0];
            rows = 0;
            columns = 0;
        }
        public DArray(int[,] new_arr)
        {
            arr = new_arr;
            rows = new_arr.GetUpperBound(0) + 1;
            columns = new_arr.Length / rows;
        }
        public DArray(int new_rows, int new_columns)
        {
            arr = new int[new_rows, new_columns];
            rows = new_rows;
            columns = new_columns;
        }
        /////////////////////////////////////////////
        ///
        new public DArray EnterArr()
        {
            string input;

            Console.WriteLine("Введіть кількість рядків та стовпців");
            input = Console.ReadLine();
            rows = int.Parse(input);

            input = Console.ReadLine();
            columns = int.Parse(input);

            DArray arr = new DArray(rows, columns);

            Console.WriteLine("Введіть значення масиву");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    input = Console.ReadLine();
                    arr.arr[i, j] = int.Parse(input);
                }
            }

            Console.WriteLine("Масив успішно заповнено!");

            return arr;
        }
        new public DArray AutoEnterArr()
        {
            string input;
            int l_bound_rand;
            int u_bound_rand;

            var rand = new Random();

            Console.WriteLine("Введіть кількість рядків та стовпців");
            input = Console.ReadLine();
            rows = int.Parse(input);

            input = Console.ReadLine();
            columns = int.Parse(input);

            DArray arr = new DArray(rows, columns);

            Console.WriteLine("Введіть мінімальний єлемент");
            input = Console.ReadLine();
            l_bound_rand = int.Parse(input);

            Console.WriteLine("Введіть максимальний єлемент");
            input = Console.ReadLine();
            u_bound_rand = int.Parse(input);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr.arr[i, j] = rand.Next(l_bound_rand, u_bound_rand);
                }
            }

            Console.WriteLine("Масив успішно заповнено!");

            return arr;
        }
        new public void OutputArr()
        {
            Console.WriteLine("Ваш масив :");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < columns * 8; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("");
        }
        public DArray Sort(DArray dArray)
        {
            int counter = 0;
            int[] tmp = new int[arr.Length];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmp[counter] = arr[i, j];
                    counter++;
                }
            }

            tmp = dArray.QuickSort(tmp);
            counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = tmp[counter];
                    counter++;
                }
            }
            return dArray;
        }
        public void DSearch(DArray dArray)
        {
            int resalt;
            int counter = 0;
            int[] tmp = new int[arr.Length];
            string input;
            int request;

            Console.WriteLine("Введіть число яке Ви хотіли би знайти");
            input = Console.ReadLine();
            request = int.Parse(input);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmp[counter] = arr[i, j];
                    counter++;
                }
            }

            resalt = dArray.BinarySearch(tmp, request);

            if (resalt <= -1)
            {
                Console.WriteLine("Число не знайдено в масиві");
            }
            else
            {
                Console.WriteLine("Індекс числа {0} в масиві = {1}", request, resalt);
            }
        }
        public DArray Del(int d, DArray dArray)
        {
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] == d)
                    {
                        arr[i, j] = arr[rows - 1, columns - counter - 1];
                        arr[rows - 1, columns - counter - 1] = 0;
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Число не знайдено у масиві");
            }
            else
            {
                Console.WriteLine("Елемент успішно занулено!");
            }

            return dArray;
        }
        public DArray AddRow(DArray dArr)
        {
            int[,] tmp = new int[rows + 1, columns];
            int[] arr = new int[columns];
            string input;
            int var;

            Console.WriteLine("Введіть усі елементи нового рядка");

            for (int i = 0; i < arr.Length; i++)
            {
                input = Console.ReadLine();
                var = int.Parse(input);
                arr[i] = var;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmp[i, j] = dArr.arr[i, j];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[rows, i] = arr[i];
            }
            rows++;
            dArr.arr = tmp;

            Console.WriteLine("Рядок успішно Додано!");

            return dArr;
        }
        public DArray DelRow(DArray dArr, int d)
        {
            int[,] tmp = new int[rows - 1, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i == d)
                {
                    continue;

                }
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        tmp[index, j] = dArr.arr[i, j];
                    }
                    index++;
                }
            }

            rows--;
            dArr.arr = tmp;

            Console.WriteLine("Рядок успішно Видалено!");

            return dArr;
        }
        public DArray Task1(DArray dArr, int k)
        {
            int tmp;
            int counter = 1;

            for (int i = 0; i < rows; i++)
            {
                if (counter % 2 == 0)
                {
                    for (int a = 0; a < k; a++)
                    {
                        for (int j = columns - 1; j >= 1; j--)
                        {
                            tmp = arr[i, j - 1];
                            arr[i, j - 1] = arr[i, j];
                            arr[i, j] = tmp;
                        }
                    }
                    counter++;
                }
                else
                {
                    counter++;
                }
            }


            return dArr;
        }
        public DArray Task2(DArray dArr)
        {
            double[,] tmp = new double[rows, columns];
            int n = tmp.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tmp[i, j] = dArr.arr[i, j];
                }
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    double koef = tmp[j, i] / tmp[i, i];
                    for (int k = i; k < n; k++)
                        tmp[j, k] -= tmp[i, k] * koef;
                }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dArr.arr[i, j] = (int)tmp[i, j];
                }
            }

            return dArr;
        }
        public void Task3(DArray dArr, int max)
        {
            double evrage;
            int counter = 0;
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum = dArr.arr[i, j] + sum;
                }
                evrage = sum / columns;

                if (evrage < max)
                {
                    counter++;
                }
                evrage = 0;
                sum = 0;
            }
            Console.WriteLine("Кількість рядків у яких середне арефметичне меньша за задане число = {0}", counter);
        }
    }
}
