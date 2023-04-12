using System;
namespace Sort
{
    public class Helping
    {
        public int[] arr;

        public static int[] AutoEnterArr()
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
            Console.WriteLine("+");

            return arr;
        }
        public static void OutputArr(int[] arr)
        {
            Console.WriteLine("Ваш масив :");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr.GetValue(i) + " ");
            }
            Console.WriteLine(";");
        }
        public static int[] Rand(int[] arr)
        {
            if (arr == null)
            {
                return arr;
            }
            int el;

            var rand = new Random();

            for (int a = 0; a < arr.Length; a++)
            {
                el = rand.Next(-100, 100);
                arr.SetValue(el, a);
            }
            Console.WriteLine("+");

            return arr;
        }
    }

}
