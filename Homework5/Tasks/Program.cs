using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name;
using System.IO;


namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            OutPutName.PrintInfo(5);
            OutPutName.Pause();
            Console.Clear();



            // Задача 1. Проверка логина.

            OutPutName.CursorOnCenter("Задача 1. Проверка логина на корректность ввода");
            OutPutName.Pause();

            bool r = false;

            do
            {
                Console.WriteLine("Введите логин (количесьво символов 2 - 10, латинские буквы, первый символ не цифра.");
                string login =  Console.ReadLine(); 
                r = WorkWithString.StrValid(login);

            }
            while (r == false  );
            Console.WriteLine("УСПЕШНО!");
            OutPutName.Pause();
            


            // Задача 2. Работа с текстом.

            OutPutName.CursorOnCenter("Задача 2. Работа с текстом.");
            OutPutName.Pause();

            Console.WriteLine("Работаем со следующим текстом:");
            Console.WriteLine();
            string messege = "Затихло всё, теперь луна Свой бледный свет на них наводит, И чарка пенного вина";

            Console.WriteLine(messege);
            string[] arrMessge = WorkWithString.ArrWords(messege);
            Console.WriteLine();

            Console.WriteLine("Введите число - максимальную длину слова");
            int l = int.Parse(Console.ReadLine());
            WorkWithString.AnythingWords(arrMessge, l);
            Console.WriteLine();

            Console.WriteLine("Введите символ, слова, заканчивающиеся на него будут удалены");
            string a = Console.ReadLine();
            WorkWithString.NoWordWithSimbol(arrMessge, a);
            Console.WriteLine();

            Console.Clear();

            // Вывод самого длинного слова и строки из самых длинных строк
            Console.WriteLine(messege);
            WorkWithString.MaxWord(arrMessge);
            OutPutName.Pause();



            // Задача 3. Сравнение строки на перестановку.

            OutPutName.CursorOnCenter("Задача 3. Сравнение строки на перестановку.");
            OutPutName.Pause();

            // Сравниваем, является ли одна строка перестановкой другой
            Console.WriteLine("Введите поочереди две строки");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            bool Comparison = WorkWithString.ComparisonWords(word1, word2);
            if (Comparison == true)
                Console.WriteLine("ДА, перестановка!");
            if (Comparison == false)
                Console.WriteLine("НЕТ, не перестановка!");
            OutPutName.Pause();



            
            // Задача 4. Сведения об учениках школы.

            OutPutName.CursorOnCenter("Задача 4. Сведения об учениках школы.");
            OutPutName.Pause();

            string[] arrSchool;
            arrSchool = WorkWithArray.LoadArrFromFile(AppDomain.CurrentDomain.BaseDirectory + "MySchool.txt");
            OutPutName.Pause();
            string[] arrSchool2  = WorkWithString.ArrWordsGood(arrSchool);

            double[] arrSchoolAverScore = WorkWithString.ArrAverScore(arrSchool2);

            double[] minAverScore = WorkWithString.MinAverScore(arrSchoolAverScore);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Худшие ученики щколы:");
            WorkWithString.OutputInform(arrSchool, minAverScore, arrSchoolAverScore);

            OutPutName.Pause();

        }

    }
}
