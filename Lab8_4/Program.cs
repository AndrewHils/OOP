using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Lab8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            char[] myText;
            List<char> myList;
            int result;

            Stopwatch SW = new Stopwatch();
            TimeSpan[] ts = new TimeSpan[2];

            text = File.ReadAllText($@"{Environment.CurrentDirectory}/MyText.txt");

            myText = new char[text.Length];
            myList = new List<char>(text.Length);

            myText = text.ToCharArray();

            Console.WriteLine("Ваш Текст:");
            foreach (var item in myText)
            {
                myList.Add(item);
            }

            foreach (var item in myText)
            {
                Console.Write(item);
            }

            SW.Start();
            result = FileText.CountUpArr(myText);
            SW.Stop();

            ts[0] = SW.Elapsed;
            SW.Reset();

            Console.WriteLine("\n\nПідрахунок прописних літер за допомогою масиву = {0}", result);
            Console.WriteLine("Час виконання функції = {0}", ts[0]);

            SW.Start();
            result = FileText.CountUpList(myList);
            SW.Stop();

            ts[1] = SW.Elapsed;
            SW.Reset();

            Console.WriteLine("\nПідрахунок прописних літер за допомогою List<T> = {0}", result);
            Console.WriteLine("Час виконання функції = {0}", ts[1]);
        }
    }
}
