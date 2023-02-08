using System;
using System.Linq;

namespace Lab1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int enter;
            bool cicle = true;
            int b;
            int var;

            Console.WriteLine("Який масив Ви би хотіли створити ?");
            Console.WriteLine("1 - Звичайний; 2 - Відсортований");

            input = Console.ReadLine();
            var = int.Parse(input);

            if (var == 1)
            {
                TArray arr = new TArray();

                Console.WriteLine("Створено одномірний масив :");
                Console.WriteLine("1 - Заповнити масив");
                Console.WriteLine("2 - Вивести масив");
                Console.WriteLine("3 - Знайти максимальний елемент");
                Console.WriteLine("4 - Знайти мінімальний елемент");
                Console.WriteLine("5 - Сортувати масив");
                Console.WriteLine("6 - Знайти суму усіх елементів");
                Console.WriteLine("7 - Додати елемент до масиву");
                Console.WriteLine("8 - Відняти елемент від масиву");
                Console.WriteLine("9 - Перемножити масив на число");
                Console.WriteLine("10 - Вийти з програми");

                while (cicle == true)
                {
                    input = Console.ReadLine();
                    enter = int.Parse(input);

                    switch (enter)
                    {
                        case 1:
                            arr = arr.EnterArr();
                            break;

                        case 2:
                            arr.OutputArr();
                            break;

                        case 3:
                            arr.Max_elem();
                            break;

                        case 4:
                            arr.Min_elem();
                            break;

                        case 5:
                            arr.Sort_Arr();
                            break;

                        case 6:
                            arr.Sum_of_Arr(arr);
                            break;

                        case 7:
                            Console.WriteLine("Введіть число для додавання");
                            input = Console.ReadLine();
                            b = int.Parse(input);
                            arr += b;
                            Console.WriteLine("Елемент успішно додано!");
                            arr.OutputArr();
                            break;

                        case 8:
                            arr--;
                            Console.WriteLine("Елемент успішно вилучено!");
                            arr.OutputArr();
                            break;

                        case 9:
                            Console.WriteLine("Введіть число для множення");
                            input = Console.ReadLine();
                            b = int.Parse(input);
                            arr *= b;
                            Console.WriteLine("Масив успішно перемножено");
                            arr.OutputArr();
                            break;

                        case 10:
                            cicle = false;
                            break;

                        default:

                            Console.WriteLine("Спробуйте ще раз!");
                            break;
                    }
                }
            }
            else if(var == 2)     
            {
                TOderedArray arr = new TOderedArray();

                Console.WriteLine("Створено одномірний масив :");
                Console.WriteLine("1 - Заповнити масив");
                Console.WriteLine("2 - Вивести масив");
                Console.WriteLine("3 - Знайти максимальний елемент");
                Console.WriteLine("4 - Знайти мінімальний елемент");
                Console.WriteLine("5 - Знайти суму усіх елементів");
                Console.WriteLine("6 - Додати елемент до масиву");
                Console.WriteLine("7 - Відняти елемент від масиву");
                Console.WriteLine("8 - Перемножити масив на число");
                Console.WriteLine("10 - Вийти з програми");

                while (cicle == true)
                {
                    input = Console.ReadLine();
                    enter = int.Parse(input);

                    switch (enter)
                    {
                        case 1:
                            arr = arr.EnterArr();
                            break;

                        case 2:
                            arr.OutputArr();
                            break;

                        case 3:
                            arr.Max_elem();
                            break;

                        case 4:
                            arr.Min_elem();
                            break;

                        case 5:
                            arr.Sum_of_Arr(arr);
                            break;

                        case 6:
                            Console.WriteLine("Введіть число для додавання");
                            input = Console.ReadLine();
                            b = int.Parse(input);
                            arr += b;
                            Console.WriteLine("Елемент успішно додано!");
                            arr.OutputArr();
                            break;

                        case 7:
                            arr--;
                            Console.WriteLine("Елемент успішно вилучено!");
                            arr.OutputArr();
                            break;

                        case 8:
                            Console.WriteLine("Введіть число для множення");
                            input = Console.ReadLine();
                            b = int.Parse(input);
                            arr *= b;
                            Console.WriteLine("Масив успішно перемножено");
                            arr.OutputArr();
                            break;

                        case 10:
                            cicle = false;
                            break;

                        default:

                            Console.WriteLine("Спробуйте ще раз!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Помилка! Спробуйте ще раз!!!");
            }

            
        }
    }
}
