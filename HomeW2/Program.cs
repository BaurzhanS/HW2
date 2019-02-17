using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 21, 36, 43, 34, 36, 21, 54, 21, 33 };
            string str = "Hello dear aunt, how are you, where is your apple?";
            ReverseNumber();
        }

        //Напечатать весь массив целых чисел
        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
        //Найти индекс максимального значения в массиве (воспользоваться функцией)
        static void FindMax(int[] arr)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            Console.WriteLine("MaxIndex={0} and Max number = {1}", index, max);

        }
        //Найти индекс максимального четного значения в массиве
        static void FindMaxEven(int[] arr)
        {
            int max_even = 0;
            int index_even = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max_even && arr[i] % 2 == 0)
                {
                    max_even = arr[i];
                    index_even = i;
                }
            }

            Console.WriteLine("Max Even Index = {0} and Max even number = {1}", index_even, max_even);
        }
        //Удалить элемент из массива по индексу.
        static void DeleteNumByIndex(ref int[] arr, int index)
        {
            int[] tmp = new int[arr.Length - 1];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (i < index)
                {
                    tmp[i] = arr[i];
                }
                else
                {
                    tmp[i] = arr[i + 1];
                }
            }
            arr = tmp;

        }
        //Удаление элементов из массива по значению
        static void DeleteNum(ref int[] arr, int num)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            int[] tmp = new int[arr.Length - count];
            int count_tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != num)
                {
                    tmp[count_tmp] = arr[i];
                    count_tmp++;
                }
            }
            arr = tmp;
        }
        //Вставить элемент в массив по индексу
        static void InsertNumByIndex(ref int[] arr, int index, int num)
        {
            int[] tmp = new int[arr.Length + 1];
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i < index)
                {
                    tmp[i] = arr[i];
                }
                else if (i > index)
                {
                    tmp[i] = arr[i - 1];
                }
                else
                {
                    tmp[i] = num;
                }
            }
            arr = tmp;
        }
        //Удалить из строки слова, в которых есть хоть одна буква последнего слова
        static void DeleteSpecificWords(ref string str)
        {
            string last_word = str.Substring(str.LastIndexOf(' ') + 1);
            string[] words = str.Split(new char[] { ' ' });
            //Console.WriteLine(last_word);
            string[] tmp = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                tmp[i] = words[i];
                for (int j = 0; j < last_word.Length - 1; j++)
                {
                    if (words[i].Contains(last_word[j]))
                    {
                        tmp[i] = words[i].Replace(words[i], "");
                    }


                }
            }

            string tmp_str = string.Join(" ", tmp);
            tmp_str = tmp_str.Replace("  ", " ");
            tmp_str = tmp_str.Trim();
            str = tmp_str;
        }
        //Удалить из строки слова, в которых есть буква 'a'
        static void DeleteWordsWhereA(ref string str)
        {
            string[] str_tmp = str.Split(' ');
            int count = 0;
            foreach (string word in str_tmp)
            {
                if (!word.Contains('a'))
                {
                    count++;
                }
            }
            string[] tmp = new string[count];
            //List<string> tmp = new List<string>(str_tmp);
            int index = 0;
            for (int i = 0; i < str_tmp.Length; i++)
            {
                if (!str_tmp[i].Contains('a'))
                {
                    tmp[index] = str_tmp[i];
                    index++;
                }

            }
            str = string.Join(" ", tmp);
        }
        //Числовые значения символов нижнего регистра в коде ASCII 
        //отличаются от значений символов верхнего регистра на величину 32. 
        //Используя эту информацию, написать программу, которая считывает 
        //с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
        static void LetterConverter()
        {
            char c = ' ';
            int tmp = 0;
            while (c != 'e')
            {
                c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (char.IsUpper(c))
                {
                    tmp = (int)c + 32;
                }
                else if (char.IsLower(c))
                {
                    tmp = (int)c - 32;
                }
                Console.WriteLine((char)tmp);
            }
        }
        /*Дано целое число N(> 0), найти число, полученное при прочтении 
         числа N справа налево.Например, если было введено число 345, 
         то программа должна вывести число 543. 
         (Подсказка – вспомните что есть строка, и как мы с ней можем работать)*/
        static void ReverseNumber()
        {
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
