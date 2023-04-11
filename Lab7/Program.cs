using System;

namespace Lab3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string enter;
            bool cicle = true;
            int var;
            int[] start_p = new int[3];
            int[] end_p = new int[3];
            int x;
            int y;
            int z;
            Vector2D A = new Vector2D();
            Vector2D B = new Vector2D();
            Vector2D C = new Vector2D(0, 0);

            Vector3D A3 = new Vector3D();
            Vector3D B3 = new Vector3D();
            Vector3D C3 = new Vector3D(0, 0 , 0);

            Console.WriteLine("Який вектор Ви би хотіли створити ?");
            Console.WriteLine("1 - Двовимірний; 2 - Тривимірний");

            input = Console.ReadLine();
            var = int.Parse(input);

            if (var == 1)
            {
                Console.WriteLine("Створено двовимірний вектор :");
                Console.WriteLine("1 - Задати координати початкової та кінцевої точок");
                Console.WriteLine("2 - Задати координати векторів А та Б");
                Console.WriteLine("3 - Отримати Довжину та Координати векторів користувача");
                Console.WriteLine("4 - Отримати Довжину та Координати результуючого вектора");
                Console.WriteLine("5 - Знайти сумму векторів");
                Console.WriteLine("6 - Помножити Вектор на число");
                Console.WriteLine("7 - Отримати скалярний добуток двух векторів");
                
                Console.WriteLine("/ - Вийти з програми");

                while (cicle == true)
                {
                    enter = Console.ReadLine();

                    switch (enter)
                    {
                        case "1":
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Введіть X та Y першої точки вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                start_p[0] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                start_p[1] = var;

                                Console.WriteLine("Введіть X та Y другої точки вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                end_p[0] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                end_p[1] = var;

                                if (i == 0)
                                {
                                    A = A.Set_Value_Arr(start_p, end_p);
                                    Console.WriteLine("Координати Першого вектору X : {0} Y : {1}, та його довжина = {2}", A.x, A.y, A.length);
                                }
                                else
                                {
                                    B = B.Set_Value_Arr(start_p, end_p);
                                    Console.WriteLine("Координати Другого вектору X : {0} Y : {1}, та його довжина = {2}", B.x, B.y, B.length);
                                }
                            }
                            break;

                        case "2":
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Введіть X та Y координати вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                x = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                y = var;

                                if (i == 0)
                                {
                                    A = A.Set_Value(x,y);
                                    Console.WriteLine("Координати Першого вектору X : {0} Y : {1}, та його довжина = {2}", A.x, A.y, A.length);
                                }
                                else
                                {
                                    B = B.Set_Value(x,y);
                                    Console.WriteLine("Координати Другого вектору X : {0} Y : {1}, та його довжина = {2}", B.x, B.y, B.length);
                                }
                            }
                            break;

                        case "3":
                            Console.WriteLine("Координати Першого вектору X : {0} Y : {1}, та його довжина = {2}", A.x,A.y,A.length);
                            Console.WriteLine("Координати Другого вектору X : {0} Y : {1}, та його довжина = {2}", B.x, B.y, B.length);
                            break;

                        case "4":
                            Console.WriteLine("Координати Першого вектору X : {0} Y : {1}, та його довжина = {2}", C.x, C.y, C.length);
                            break;

                        case "5":
                            C = A.Sum(A, B);
                            Console.WriteLine("Вектори успішно сумовані, данні записані у результуючий вектор");
                            break;

                        case "6":
                            Console.WriteLine("Введіть число на яке Ви би хотіли помножити перший вектор");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            C = A.Vec_on_Num(A, var);
                            Console.WriteLine("Вектори успішно помножено, данні записані у результуючий вектор");
                            break;

                        case "7":
                            var = A.Multi(A, B);
                            Console.WriteLine("Вектори успішно перемножені, результат = {0}", var);
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
            else
            {
                Console.WriteLine("Створено тривимірний вектор :");
                Console.WriteLine("1 - Задати координати початкової та кінцевої точок");
                Console.WriteLine("2 - Задати координати векторів А та Б");
                Console.WriteLine("3 - Отримати Довжину та Координати векторів користувача");
                Console.WriteLine("4 - Отримати Довжину та Координати результуючого вектора");
                Console.WriteLine("5 - Знайти сумму векторів");
                Console.WriteLine("6 - Помножити Вектор на число");
                Console.WriteLine("7 - Отримати скалярний добуток двух векторів");

                Console.WriteLine("/ - Вийти з програми");

                while (cicle == true)
                {
                    enter = Console.ReadLine();

                    switch (enter)
                    {
                        case "1":
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Введіть X, Y та Z першої точки вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                start_p[0] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                start_p[1] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                start_p[2] = var;

                                Console.WriteLine("Введіть X, Y та Z другої точки вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                end_p[0] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                end_p[1] = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                end_p[2] = var;

                                if (i == 0)
                                {
                                    A3 = A3.Set_Value_Arr(start_p, end_p);
                                    Console.WriteLine("Координати Першого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", A3.x, A3.y, A3.z, A3.length);
                                }
                                else
                                {
                                    B3 = B3.Set_Value_Arr(start_p, end_p);
                                    Console.WriteLine("Координати Другого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", B3.x, B3.y, B3.z, B3.length);
                                }
                            }
                            break;

                        case "2":
                            for (int i = 0; i < 2; i++)
                            {
                                Console.WriteLine("Введіть X, Y та Z координати вектору");

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                x = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                y = var;

                                input = Console.ReadLine();
                                var = int.Parse(input);

                                z = var;

                                if (i == 0)
                                {
                                    A3 = A3.Set_Value(x, y, z);
                                    Console.WriteLine("Координати Першого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", A3.x, A3.y, A3.z, A3.length);
                                }
                                else
                                {
                                    B3 = B3.Set_Value(x, y, z);
                                    Console.WriteLine("Координати Другого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", B3.x, B3.y, B3.z, B3.length);
                                }
                            }
                            break;

                        case "3":
                            Console.WriteLine("Координати Першого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", A3.x, A3.y, A3.z, A3.length);
                            Console.WriteLine("Координати Другого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", B3.x, B3.y, B3.z, B3.length);
                            break;

                        case "4":
                            Console.WriteLine("Координати Результуючого вектору X : {0} Y : {1} Z : {2}, та його довжина = {3}", C3.x, C3.y, C3.z, C3.length);
                            break;

                        case "5":
                            C3 = A3.Sum(A3, B3);
                            Console.WriteLine("Вектори успішно сумовані, данні записані у результуючий вектор");
                            break;

                        case "6":
                            Console.WriteLine("Введіть число на яке Ви би хотіли помножити перший вектор");

                            input = Console.ReadLine();
                            var = int.Parse(input);

                            C3 = A3.Vec_on_Num(A3, var);
                            Console.WriteLine("Вектори успішно помножено, данні записані у результуючий вектор");
                            break;

                        case "7":
                            var = A3.Multi(A3, B3);
                            Console.WriteLine("Вектори успішно перемножені, результат = {0}", var);
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
