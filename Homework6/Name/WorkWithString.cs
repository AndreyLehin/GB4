using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    public class WorkWithString
    {

        /// <summary>
        /// Проверяет логин на корректность ввода
        /// </summary>
        /// <param name="messege">Логин</param>
        /// <returns></returns>
        public static bool StrValid(string messege)
        {
            int a = messege.Length;
            if (a < 2 || a > 10)
            {
                Console.WriteLine("Не верная длина логина");
                Console.WriteLine();
                return false;
            }
            char[] c = messege.ToCharArray();
            if (char.IsNumber(c[0]))
            {
                Console.WriteLine("Первый симовол не может быть число");
                Console.WriteLine();
                return false;
            }
            int s;
            string arr1 = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            int l = arr1.Length;
            for (int i = 0; i < a; i++)
            {
                s = 0;
                for (int j = 0; j < l; j++)
                {
                    if (c[i] == arr1[j])
                    {
                        s = 1;
                    }
                }
                if (s == 0)
                {
                    Console.WriteLine("Использован недопустимый символ");
                    Console.WriteLine();
                    return false;

                }
            }

            return true;

        }


        /// <summary>
        /// Создает массив из слов текста
        /// </summary>
        /// <param name="messege"></param>
        /// <returns></returns>
        public static string[] ArrWords(string messege)
        {
            messege = messege.Trim();
            char[] c = {',', '.', ';', ':',' ', '-', '(', ')'};
            string [] arr1 = messege.Split(c, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine($"{arr1.Length} слов в тексте");

            foreach (var word in arr1)
            {
                Console.WriteLine(word);
            }
           
            return arr1;
        }

        /// <summary>
        /// Выводит слова без заданного символа в конце
        /// </summary>
        /// <param name="arr">массив слов</param>
        /// <param name="a">заданный символ</param>
        public static void NoWordWithSimbol(string[]arr, string a)
        {

            string f;

            for (int i = 0; i < arr.Length; i++)
            {
                f =arr[i].Substring(arr[i].Length - 1);
                if (f != a)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }

        /// <summary>
        /// Выводит слова определенной длины
        /// </summary>
        /// <param name="arr">массив слов</param>
        /// <param name="a">максимальная длина слова</param>
        public static void AnythingWords(string[]arr, int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= a)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }

        /// <summary>
        /// Выводит первое самое длинное слово и строку из самых длинных строк
        /// </summary>
        /// <param name="arr">массив слов</param>
        public static void MaxWord(string[]arr)
        {

            int q = 0;
            int max = arr[0].Length;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length > max)
                {
                    max = arr[i].Length;
                    q = i;

                }

            }
            Console.WriteLine();
            Console.WriteLine(" Первое самое длинное слово в тексте:");
            Console.WriteLine(arr[q]);
            Console.WriteLine();

            Console.WriteLine(" Строка из самых длинных слов");
            StringBuilder str1 = new StringBuilder(100);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == max)
                {
                    str1.Append($" {arr[i]}");

                }
            }
            Console.WriteLine();
            Console.WriteLine(str1);
            
        }

        /// <summary>
        /// Сравнивает 2 строки 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool ComparisonWords(string a, string b)
        {
            int q = a.Length;
            int w = b.Length;
            
            if (q != w)
                return false;

            int d;
            for (int j = 0; j < q; j++)
            {
                d = 0;
                for (int k = 0; k < w; k++)
                {
                    if (a[j] == b[k])
                    {
                        d = 1;
                    }

                }

                if (d!=1)
                    return false;
            }

            return true;    
        }


        /// <summary>
        /// Очищает массив от мусора
        /// </summary>
        /// <param name="messege"></param>
        /// <returns></returns>
        public static string[] ArrWordsGood(string [] messege)
        {
            string[] arr1 = new string[messege.Length];
            for (int i = 0; i < messege.Length; i++)
            {

                arr1[i] = messege[i].Trim();
                
            }

            return arr1;
        }

        /// <summary>
        /// Создает массив средних баллов учеников школы (из трех оценок)
        /// </summary>
        /// <param name="messege"></param>
        /// <returns></returns>
        public static double [] ArrAverScore(string[]messege)
        {
            double [] arr = new double[messege.Length];
            for ( int i = 0; i < arr.Length; i++ )
            {
                string gpa = messege[i];
                gpa = gpa.Substring(gpa.Length - 5);
              
                arr[i] = (double.Parse(gpa[0].ToString()) + double.Parse(gpa[2].ToString()) + double.Parse(gpa[4].ToString()))/3;
            }
            return arr;
        }

        /// <summary>
        /// Возвращает массив и 3-х наименьших средних баллах по школе
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double[] MinAverScore(double[]arr)
        {
            double min1 = arr[0];
            double min2 = arr[0];
            double min3 = arr[0];
          
            for ( int i = 1; i < arr.Length; i++ )
            {
                if ( arr[i] < min1 )
                {
                    min1 = arr[i];
                    break;
                }

                if (arr[i] < min2)
                {
                    min2 = arr[i];
                    break;
                }

                if (arr[i] < min3)
                {
                    min3 = arr[i];
                    break;
                }
            }


           double [] min ={ min1, min2, min3};
            Console.WriteLine("Три наименьших средних балла:");
            Console.WriteLine($"  {min[0]}, {min[1]}, {min[2]}");

            return min;

        }


        /// <summary>
        /// Выводит инф об учениках
        /// </summary>
        /// <param name="arrSchool"></param>
        /// <param name="min"></param>
        /// <param name="averScore"></param>
        public static void OutputInform(string[]arrSchool, double[]min, double[] averScore)
        {

            int q = 0;
             for ( int i = 0; i < arrSchool.Length; i++ )
            {
                if (min[0] == averScore[i])
                {
                    q++;
                    Console.WriteLine($" {q}. {arrSchool[i]}.   Средний балл:  {averScore[i]}");
                    break;
                }

            }
             if ( q < 3 )
            {
                for ( int i = 0; i < arrSchool.Length; i++ )
                {
                    if (min[1] == averScore[i])
                    {
                        q++;
                        Console.WriteLine($" {q}. {arrSchool[i]}.   Средний балл:  {averScore[i]}");
                        break;
                    }
                }

            }

            if (q < 3)
            {
                for (int i = 0; i < arrSchool.Length; i++)
                {
                    if (min[2] == averScore[i])
                    {
                        q++;
                        Console.WriteLine($" {q}. {arrSchool[i]}.   Средний балл:  {averScore[i]}");
                    }
                }
            }
        }
    }
}
