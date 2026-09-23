using System;

namespace WordCounter 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            char[] separators = new char[]
            {
                ' ', '\t', '\n', '\r',
                ',', '.', '!', '?', ';', ':', '-', '—'
            };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Количество слов: {words.Length}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}