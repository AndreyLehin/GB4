using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Name;

namespace Tasks6
{
    public delegate double Fun(double x, double y);
    public delegate double Fun2(double x);

    internal class Program

    {
        static void Main(string[] args)
        {

            OutPutName.PrintInfo(6);
            OutPutName.Pause();
            Console.Clear();


             
            // Задача 1. Работа с делегатом

            OutPutName.CursorOnCenter("Задача 1. Работа с делегатом");
            OutPutName.Pause();

            Console.WriteLine("Функции: F = a * x^2,  F = a * sin(x)");

            Console.WriteLine("Введите число : a");
            double a = double.Parse(Console.ReadLine());


            Console.WriteLine("Введите число : x");
            double x = double.Parse(Console.ReadLine());

            Table(MyFun, MyFun2, x, a);
            OutPutName.Pause();




            // Задача 2. Работа с функциями, файлами и делегатами

            Console.WriteLine (   "Задача 2. Есть две функции. Вам нужно будет выбрать,\n с какой работать, а потом " +
                "выбрать диапазон,\n в котором нужно будет найти минимум");
            OutPutName.Pause();
            Console.WriteLine("выберите функцию: нажмите 1, если    F = 5 * x * x    ; нажмите 2, если F = a * Math.Sin(x)  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите диапазо для Х. Min и Max");
            double v = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг для X");
            double h = double.Parse(Console.ReadLine());


            string t;
            if (n == 1)
            {
                t = "5 * x * x";

            }
            else t = "5 * sin(x)";

            SaveFunc("Data.bin", MyFun3, MyFun4, n, v, b, h);
            Console.Write($" Минимальное значение из диапазона Х от {v}  до  {b}  функции  ({t})  равно:  ");
            Console.Write(Load("Data.bin"));
            OutPutName.Pause();

        }

        public static double MyFun(double a, double x)
        {
            return a * x *x;
        }

        public static double MyFun2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        public static void Table(Fun Q, Fun W, double x, double a)
        {
            Console.WriteLine();

            int i =0;
            if (x > 0)
            {
                while (i < x)
                {
                    Console.WriteLine();
                    Console.WriteLine($" x = {i}    F = a * x^2 = {Q(a, i)}      F = a * sin(x) = {W(a, i)}");
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine($" x = {x}    F = a * x^2 = {Q(a, x)}      F = a * sin(x) = {W(a, x)}");
            }

            if (x < 0)
            {
                while (i > x)
                {
                    Console.WriteLine();
                    Console.WriteLine($" x = {i}    F = a * x^2 = {Q(a, i)}      F = a * sin(x) = {W(a, i)}");
                    i--;
                }
                Console.WriteLine();
                Console.WriteLine($" x = {x}    F = a * x^2 = {Q(a, x)}      F = a * sin(x) = {W(a, x)}");
            }

        }


        // Для задачи 2.

        public static double MyFun3 (double x)
        {
            return 5 * x * x;
        }


        public static double MyFun4(double x)
        {
            return 5 * Math.Sin(x);
        }



        /// <summary>
        /// считывает файл и записывает другой файл в пределах диапазона значений
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="Q">делегат метода</param>
        /// <param name="W">делегат метода</param>
        /// <param name="n">переменная 1 или 2</param>
        /// <param name="a">диапозон мин</param>
        /// <param name="b">диапозон макс</param>
        /// <param name="h">шаг</param>
        public static void SaveFunc (string fileName, Fun2 Q, Fun2 W, int n, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            if (n == 1)
            {
                while (x <= b)
                {
                    bw.Write(Q(x));
                    x += h;
                }
            }
            else
            {
                while (x <= b)
                {
                    bw.Write(W(x));
                    x += h;
                }

            }
            fs.Close();
            bw.Close();
        }

        /// <summary>
        /// Находит мин значение в файле. Считывает поток
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double Load (string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length/sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < min) min = d;

            }

            br.Close();
            fs.Close();
            return min;
        }
    }
}
