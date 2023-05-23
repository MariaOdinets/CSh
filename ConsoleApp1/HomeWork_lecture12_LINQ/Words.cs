using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_homeworks.HomeWork_lecture9_Collections;

namespace TMS_homeworks.HomeWork_lecture12_LINQ
{
    public static class Words
    {        
        public static string[]? words { get; set; }

        //Метод возвращает первое слово из последовательности слов, содержащее только одну букву
        public static string GetOneLetterWord(string[] words)
        {
            return words.FirstOrDefault(words => words.Length == 1);
        }

        //метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
        public static string GetLastSubstringWord(string[] words)
        {
            return words.LastOrDefault(words => words.Contains("ee"));
        }

        //Напишите метод, который возвращает количество уникальных значений в массиве.
        public static int GetQntyUniqueValues(string[] words)
        {
            return words.Distinct().Count();
        }

        //Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно) те значение которые содержат 3
        public static IEnumerable<string> GetValuesWith3(IEnumerable<string> words)
        {
            return words.Skip(4).Where(words => words.Contains('3'));
        } //пока не работает

        //Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max.Если нет слов, соответствующих условию, метод возвращает null.
        public static string GetLastLengthWord(string[] words, int min = 1, int max = 5)
        {
            return words.LastOrDefault(words => words.Length >= min && words.Length <= max);
        }

        //Метод возвращает длину самого короткого слова
        public static int GetLengthOfShortest(string[] words)
        {
            return words.OrderBy(words => words.Length).First().Length;
        }

        //Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение
    }
}