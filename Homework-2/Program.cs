using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            Stopwatch stopwatch3 = Stopwatch.StartNew();

            List<int> rezList = new List<int>();
           
            //******************************************************************************************************************
            //Коллекция List
            List<int> listInt = new List<int>();

            stopwatch1.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                listInt.Add(i);
            }
            stopwatch1.Stop();

            Console.WriteLine($"Время заполнение List: {stopwatch1.ElapsedMilliseconds}");

            //Поиск элемента 496753
            stopwatch1.Restart();
            var el = listInt.FindIndex(i => i > 496753);
            stopwatch1.Stop();
            Console.WriteLine($"Элемент 496753: {el}\nЗатраченное время на поиск: {stopwatch1.ElapsedMilliseconds}{Environment.NewLine}");

            //Деление без остатка на 777
            stopwatch1.Restart();
            foreach (var item in listInt)
            {
                if (item % 777 == 0)
                {
                    rezList.Add(item);
                }
            }
            //Вывод
            foreach (var item in rezList)
            {
                Console.Write($"{item},");
            }
            stopwatch1.Stop();
            Console.WriteLine($"Затраченное время на деление без остатка: {stopwatch1.ElapsedMilliseconds}{Environment.NewLine}");

            //******************************************************************************************************************
            //Коллекция ArrayList
            ArrayList arrayList = new ArrayList();
            stopwatch2.Start();

            for (int i = 1; i <= 1000000; i++)
            {
                arrayList.Add(i);
            }
            stopwatch2.Stop();

            Console.WriteLine($"Время заполнение ArrayList: {stopwatch2.ElapsedMilliseconds}");

            //Поиск элемента 496753
            stopwatch2.Restart();
            var el2 = arrayList[496753];
            stopwatch2.Stop();
            Console.WriteLine($"Элемент 496753: {el2}\nЗатраченное время на поиск: {stopwatch2.ElapsedMilliseconds}{Environment.NewLine}");

            //Деление без остатка на 777
            rezList.Clear();
            stopwatch2.Restart();
            foreach (int item in arrayList)
            {
                if (item % 777 == 0)
                {
                    rezList.Add(item);
                }
            }
            //Вывод
            foreach (var item in rezList)
            {
                Console.Write($"{item},");
            }
            stopwatch2.Stop();
            Console.WriteLine($"Затраченное время на деление без остатка: {stopwatch2.ElapsedMilliseconds}{Environment.NewLine}");
            


            //******************************************************************************************************************
            //Коллекция LinkedList
            LinkedList<int> linkListInt = new LinkedList<int>();
            stopwatch3.Start();

            for (int i = 1; i <= 1000000; i++)
            {
                linkListInt.AddLast(i);
            }
            stopwatch3.Stop();

            Console.WriteLine($"Время заполнение LinkedList: {stopwatch3.ElapsedMilliseconds}");

            //Поиск элемента 496753
            stopwatch3.Restart();
            var el3 = linkListInt.ElementAt(496753);
            stopwatch3.Stop();
            Console.WriteLine($"Элемент 496753: {el3}\nЗатраченное время на поиск: {stopwatch3.ElapsedMilliseconds}{Environment.NewLine}");

            //Деление без остатка на 777
            rezList.Clear();
            stopwatch3.Restart();
            foreach (int item in linkListInt)
            {
                if (item % 777 == 0)
                {
                    rezList.Add(item);
                }
            }
            //Вывод
            foreach (var item in rezList)
            {
                Console.Write($"{item},");
            }
            stopwatch3.Stop();
            Console.WriteLine($"Затраченное время на деление без остатка: {stopwatch3.ElapsedMilliseconds}{Environment.NewLine}");



            Console.ReadLine(); 


        }
    }
}
