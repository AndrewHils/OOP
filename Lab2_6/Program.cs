using System;

namespace Lab2_6.Scherbina
{
        class Program
    {
        static void Main(string[] args)
        {
            string input;
            string enter;
            bool cicle = true;
            int b;
            int var;

            Console.WriteLine("Який масив Ви би хотіли створити ?");
            Console.WriteLine("1 - Звичайний; 2 - Двовимірний");

            input = Console.ReadLine();
            var = int.Parse(input);

            if (var == 1)
            {
                TArray arr = new TArray();

                Console.WriteLine("Створено одномірний масив :");
                Console.WriteLine("1 - Заповнити масив в ручну");
                Console.WriteLine("2 - Заповнити масив автоматично");
                Console.WriteLine("3 - Вивести масив");
                Console.WriteLine("4 - Сортувати масив");
                Console.WriteLine("5 - Знайти індекс числа у масиві");
                Console.WriteLine("6 - Видалити число з масиву");
                Console.WriteLine("7 - Додати число на певний індекс масиву");
                Console.WriteLine("8 - Додати число у кінець масиву");
                Console.WriteLine("9 - Виконати завдання 1.1");
                Console.WriteLine("10 - Виконати завдання 1.2");
                Console.WriteLine("11 - Виконати завдання 1.3");
                Console.WriteLine("/ - Вийти з програми");

                while (cicle == true)
                {
                    input = Console.ReadLine();
                    enter = input;

                    switch (enter)
                    {
                        case "1":
                            arr = arr.EnterArr();
                            break;

                        case "2":
                            arr = arr.AutoEnterArr();
                            break;

                        case "3":
                            arr.OutputArr();
                            break;

                        case "4":
                            arr.elements = arr.QuickSort(arr.elements);
                            Console.WriteLine("Ваш масив успішно відсортовано");
                            break;

                        case "5":
                            Console.WriteLine("Введіть число яке Ви хотіли би знайти");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            int resalt = arr.BinarySearch(arr.elements, var);

                            if (resalt <= -1)
                            {
                                Console.WriteLine("Число не знайдено в масиві");
                            }
                            else
                            {
                                Console.WriteLine("Індекс числа {0} в масиві = {1}", var, resalt);
                            }

                            break;

                        case "6":
                            Console.WriteLine("Введіть число яке Ви хотіли би видалити");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            arr.elements = arr.Del(arr.elements, var);

                            break;

                        case "7":
                            Console.WriteLine("Введіть число яке Ви хотіли би додати та його індекс");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            input = Console.ReadLine();
                            int var2 = int.Parse(input);

                            arr.elements = arr.Insert(arr.elements, var, var2);

                            break;

                        case "8":
                            Console.WriteLine("Введіть число для додавання");
                            input = Console.ReadLine();
                            b = int.Parse(input);
                            arr += b;
                            Console.WriteLine("Елемент успішно додано!");
                            arr.OutputArr();
                            break;

                        case "9":
                            arr.elements = arr.Task1(arr.elements);
                            arr.OutputArr();
                            break;

                        case "10":
                            arr.Task2();
                            break;

                        case "11":
                            Console.WriteLine("Введіть 1 для встановлення границі Індексів або 2 для встановлення границі Значень у масиві");

                            input = Console.ReadLine();
                            var = int.Parse(input);
                            int lower_b;
                            int upper_b;

                            if (var == 1)
                            {
                                Console.WriteLine("Введіть нижню та верхню границю для вилучення значень з масиву");
                                input = Console.ReadLine();
                                lower_b = int.Parse(input);
                                input = Console.ReadLine();
                                upper_b = int.Parse(input);

                                arr.elements = arr.Task3_1(arr.elements, lower_b, upper_b);

                                Console.WriteLine("Елементи успішно вилучено вилучення");
                                arr.OutputArr();
                            }
                            else
                            {
                                Console.WriteLine("Введіть нижню та верхню границю для вилучення значень з масиву");
                                input = Console.ReadLine();
                                lower_b = int.Parse(input);
                                input = Console.ReadLine();
                                upper_b = int.Parse(input);

                                arr.elements = arr.Task3_2(arr.elements, lower_b, upper_b);

                                Console.WriteLine("Елементи успішно вилучено вилучення");
                                arr.OutputArr();
                            }
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

            else if (var == 2)
            {
                DArray dArr = new DArray();

                Console.WriteLine("Створено двовимірний масив :");
                Console.WriteLine("1 - Заповнити масив в ручну");
                Console.WriteLine("2 - Заповнити масив автоматично");
                Console.WriteLine("3 - Вивести масив");
                Console.WriteLine("4 - Сортувати масив");
                Console.WriteLine("5 - Знайти індекс числа у масиві");
                Console.WriteLine("6 - Занулити число у масиві");
                Console.WriteLine("7 - Додати рядок до масиву");
                Console.WriteLine("8 - Видалити рядок з масиву");
                Console.WriteLine("9 - Виконати завдання 2.1");
                Console.WriteLine("10 - Виконати завдання 2.2");
                Console.WriteLine("11 - Виконати завдання 2.3");
                Console.WriteLine("/ - Вийти з програми");

                while (cicle == true)
                {
                    input = Console.ReadLine();
                    enter = input;

                    switch (enter)
                    {
                        case "1":
                            dArr = dArr.EnterArr();
                            break;

                        case "2":
                            dArr = dArr.AutoEnterArr();
                            break;

                        case "3":
                            dArr.OutputArr();
                            break;

                        case "4":
                            dArr = dArr.Sort(dArr);
                            Console.WriteLine("Ваш масив успішно відсортовано");
                            break;

                        case "5":
                            dArr.DSearch(dArr);
                            break;

                        case "6":
                            Console.WriteLine("Введіть число яке Ви хотіли би занулити");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            dArr = dArr.Del(var, dArr);

                            break;

                        case "7":
                            dArr = dArr.AddRow(dArr);

                            break;

                        case "8":
                            Console.WriteLine("Введіть індекс рядка який Ви хотіли би видалити");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            if (var <= dArr.rows)
                            {
                                dArr = dArr.DelRow(dArr, var);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введене число більше за кількість рядків! Спробуйте ще");
                            }
                            break;

                        case "9":
                            Console.WriteLine("Введіть число k - зміщення на кількість позицій");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            dArr = dArr.Task1(dArr , var);
                            dArr.OutputArr();
                            break;

                        case "10":
                            dArr = dArr.Task2(dArr);
                            dArr.OutputArr();
                            break;

                        case "11":
                            Console.WriteLine("Введіть максимальне число");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            dArr.Task3(dArr, var);
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
}
