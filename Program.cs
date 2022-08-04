using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задание 3
    Пользователь вводит строку с клавиатуры. Необходимо зашифровать 
данную строку используя шифр Цезаря.
    Кроме механизма шифровки, реализуйте механизм расшифрования.
 */

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите произвольную фразу: ");
            string phrase = Console.ReadLine();
            //string newPhrase = "";
            int size = phrase.Length;
            char[] bew = new char[size];

            for (int i = 0; i < phrase.Length; i++)
            {
                bew[i] = Convert.ToChar(phrase[i] + 3);
            }
            Console.WriteLine(" Новый массив");
            for (int i = 0; i < bew.Length; i++)
            {
                Console.Write(bew[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < phrase.Length; i++)
            {
                bew[i] = Convert.ToChar(bew[i] - 3);
            }
            Console.WriteLine(" Массив расшифрованный ");
            for (int i = 0; i < bew.Length; i++)
            {
                Console.Write(bew[i]);
            }
            Console.WriteLine();
        }
    }
}
