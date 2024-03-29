﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture4
{
    internal class Homework4
    {
        /// <summary>
        /// Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        public static void Task1()
        {
            string text = "222test testing tester 16545 1 55 111.545 454 777,554 tes t TEST";

            text = Regex.Replace(text, @"test", "testing", RegexOptions.IgnoreCase);
            text = Regex.Replace(text, @"\d*", ""); //подскажи пожалуйста, можно ли (=как) записать в одну строку?

            Console.WriteLine(text);
        }

        /// <summary>
        /// Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Welcome to the TMS lessons
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2() // есть сомнение, что я правильно поняла формулировку задачи , если надо переделать , сообщи, пожалуйста
        {
            string[] words = { "Welcome", "to", "the", "TMS", "lessons" };

            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        ///Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        ///Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string initialString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string[] subStrings = initialString.Split("abc");

            foreach (string subString in subStrings)
            {
                Console.WriteLine(subString);
            }
        }

        /// <summary>
        /// Дана строка: Плохой день.
        /// Необходимо с помощью метода substring удалить слово "плохой". 
        /// После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        /// Заменить последний "!" на "?"
        /// </summary>
        public static void Task4()
        {
            string initial = "Плохой день";
            StringBuilder changedString = new StringBuilder(initial.Substring(initial.IndexOf(" ")));

            changedString.Insert(0, "Хороший").Insert(changedString.Length, "!!!!!!!!!");
            changedString.Replace('!', '?', changedString.Length - 1, 1);

            Console.WriteLine(changedString);
        }

        /// <summary>
        /// Написать программу со следующим функционалом:
        /// На вход передать строку(будем считать, что это номер документа).
        /// Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
        /// Вывести на экран в одну строку два первых блока по 4 цифры.
        /// Вывести на экран номер документа, но блоки из трех букв заменить на*** (каждая буква заменятся на*).
        /// Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
        /// Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
        /// Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью).
        /// Проверить начинается ли номер документа с последовательности 555.
        /// Проверить заканчивается ли номер документа на последовательность 1a2b. 
        /// Все эти методы реализовать в отдельном классе в статических методах, которые на вход(входным параметром) будут принимать вводимую на вход программы строку.
        /// </summary>
        public static void Task5()
        {

        }
    }
}
