using System;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr;
            string input;
            string enter;
            int answer;
            int asked;
            bool cicle = true;
            int i = 0;
            string[] nos = new string[1];

            Helping h = new Helping();

            Stopwatch SW = new Stopwatch();

            TimeSpan [] ts = new TimeSpan[1];

            arr = h.arr;

            Console.WriteLine("1 - Enter Data");
            Console.WriteLine("2 - Output");
            Console.WriteLine("3 - 9 -- All sorts of SORTS");
            Console.WriteLine("10 - Output The Final Table of Time");
            Console.WriteLine("11 - 14  ---  All kindes of SEARCH");
            Console.WriteLine("r - To Rand an Array");
            Console.WriteLine("/ - Exit The F* Program");

            while (cicle == true)
            {
                input = Console.ReadLine();
                enter = input;

                switch (enter)
                {
                    case "1":
                        arr = Helping.AutoEnterArr();
                        break;

                    case "2":
                        Helping.OutputArr(arr);
                        break;

                    case "3":
                        nos[i] = "Сортування Вибором";

                        SW.Start();
                        arr = MySorts.SelectionSort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "4":
                        nos[i] = "Сортування Вставкою";

                        SW.Start();
                        arr = MySorts.InsertionSort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "5":
                        nos[i] = "Бульбашкове Сортування";

                        SW.Start();
                        arr = MySorts.BubbleSort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "6":
                        nos[i] = "Сортування Шелла";

                        SW.Start();
                        arr = MySorts.ShellSort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "7":
                        nos[i] = "Пірамідальне сортування";

                        SW.Start();
                        MySorts.HeapSort(arr, arr.Length);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "8":
                        nos[i] = "Швидке сортування";

                        SW.Start();
                        arr = MySorts.QuickSort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "9":
                        nos[i] = "Introspective sort C#";

                        SW.Start();
                        Array.Sort(arr);
                        SW.Stop();

                        Helping.OutputArr(arr);

                        ts[i] = SW.Elapsed;
                        Array.Resize(ref ts, ts.Length + 1);
                        Array.Resize(ref nos, nos.Length + 1);
                        SW.Reset();
                        Console.WriteLine(ts[i]);
                        i++;
                        break;

                    case "10":
                        for (int a = 0; a < ts.Length - 1; a++)
                        {
                            Console.Write("{0}          ",ts[a]);
                            Console.WriteLine("--       " + nos[a]);
                            Console.WriteLine();
                        }
                        break;

                    case "11":
                        Console.WriteLine("Enter The desired Number");

                        input = Console.ReadLine();
                        asked = int.Parse(input);

                        SW.Start();
                        answer = MySearch.BinarySearch(arr, asked);
                        SW.Stop();

                        if (answer == -1)
                        {
                            Console.WriteLine("Число не знайдено в масиві");
                            SW.Reset();
                        }
                        else
                        {
                            nos[i] = "Бінарний Пошук";
                            ts[i] = SW.Elapsed;
                            Array.Resize(ref ts, ts.Length + 1);
                            Array.Resize(ref nos, nos.Length + 1);
                            SW.Reset();
                            Console.WriteLine("Індекс числа {0} = {1}", asked, answer);
                            Console.WriteLine(ts[i]);
                            i++;
                        }
                            
                        break;

                    case "12":
                        Console.WriteLine("Enter The desired Number");

                        input = Console.ReadLine();
                        asked = int.Parse(input);

                        SW.Start();
                        answer = MySearch.LіnSearch(arr, asked);
                        SW.Stop();

                        if (answer == -1)
                        {
                            Console.WriteLine("Число не знайдено в масиві");
                            SW.Reset();
                        }
                        else
                        {
                            nos[i] = "Лінійний Пошук";
                            ts[i] = SW.Elapsed;
                            Array.Resize(ref ts, ts.Length + 1);
                            Array.Resize(ref nos, nos.Length + 1);
                            SW.Reset();
                            Console.WriteLine("Індекс числа {0} = {1}", asked, answer);
                            Console.WriteLine(ts[i]);
                            i++;
                        }

                        break;

                    case "13":
                        Console.WriteLine("Enter The desired Number");

                        input = Console.ReadLine();
                        asked = int.Parse(input);

                        SW.Start();
                        answer = MySearch.LіnSearchQuіck(arr, asked);
                        SW.Stop();

                        if (answer == -1)
                        {
                            Console.WriteLine("Число не знайдено в масиві");
                            SW.Reset();
                        }
                        else
                        {
                            nos[i] = "Лінійний пошук з барьером";
                            ts[i] = SW.Elapsed;
                            Array.Resize(ref ts, ts.Length + 1);
                            Array.Resize(ref nos, nos.Length + 1);
                            SW.Reset();
                            Console.WriteLine("Індекс числа {0} = {1}", asked, answer);
                            Console.WriteLine(ts[i]);
                            i++;
                        }

                        break;

                    case "14":
                        Console.WriteLine("Enter The desired Number");

                        input = Console.ReadLine();
                        asked = int.Parse(input);

                        SW.Start();
                        answer = MySearch.Search(arr, asked, arr.Length);
                        SW.Stop();

                        if (answer == -1)
                        {
                            Console.WriteLine("Число не знайдено в масиві");
                            SW.Reset();
                        }
                        else
                        {
                            nos[i] = "Пошук з Транспонуванням";
                            ts[i] = SW.Elapsed;
                            Array.Resize(ref ts, ts.Length + 1);
                            Array.Resize(ref nos, nos.Length + 1);
                            SW.Reset();
                            Console.WriteLine("Індекс числа {0} = {1}", asked, answer);
                            Console.WriteLine(ts[i]);
                            i++;
                        }

                        break;

                    case "15":
                        Console.WriteLine("Enter The desired Number");

                        input = Console.ReadLine();
                        asked = int.Parse(input);

                        SW.Start();
                        answer = Array.IndexOf(arr, asked);
                        SW.Stop();

                        if (answer == -1)
                        {
                            Console.WriteLine("Число не знайдено в масиві");
                            SW.Reset();
                        }
                        else
                        {
                            nos[i] = "Metod IndexOf C#";
                            ts[i] = SW.Elapsed;
                            Array.Resize(ref ts, ts.Length + 1);
                            Array.Resize(ref nos, nos.Length + 1);
                            SW.Reset();
                            Console.WriteLine("Індекс числа {0} = {1}", asked, answer);
                            Console.WriteLine(ts[i]);
                            i++;
                        }

                        break;

                    case "r":
                        arr = Helping.Rand(arr);
                        break;

                    case "/":
                        cicle = false;
                        break;

                    default:

                        Console.WriteLine("Спробуйте ще раз!");
                        break;
                }
            }
        }
    }
}
