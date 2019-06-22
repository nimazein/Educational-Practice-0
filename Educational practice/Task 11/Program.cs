using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        /* О шифре
         
             Кодируются английские заглавные и строчные буквы, пробел и знаки препинания.
             Каждый из символов кодируется двоичным числом длиной в 7 символов.
             Кодирование происходит всеми числами двоичной системы, начиная с 000000 
             и заканчивая 111111, кодируемые символы расположены в порядке:
             1) Заглавные буквы
             2) Строчные буквы
             3) Цифры
             4) Пробел
             
             Пример: Символ 'А' кодируется числом 000000, 'D' - 000011
         */

        static string text;
        static Dictionary dictionary = new Dictionary();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            dictionary.FillDictionary();
            ReadText();
            Console.WriteLine("Закодированный текст: ");
            string codedText = CodeText();
            Console.ReadKey();

            Console.WriteLine("Раскодированный текст: ");
            DecodeString(codedText);
            Console.ReadKey();
                
        }
        static void ReadText()
        {
            text = @"Twinkle, twinkle, little star,
How I wonder what you are.
Up above the world so high,
Like a diamond in the sky.";
        }
        static string CodeText()
        {
            StringBuilder codedText = new StringBuilder("");

            foreach (char symbol in text)
            {
                if (dictionary.Symbols.Contains(symbol.ToString()))
                {
                    int idx = dictionary.Symbols.IndexOf(symbol.ToString());
                    codedText.Append(dictionary.Codes[idx] + " ");
                }
                else
                {
                    int idx = dictionary.Symbols.IndexOf("\n");
                    codedText.Append(dictionary.Codes[idx] + " ");
                }
            }
            Console.WriteLine(codedText);
            return codedText.ToString();
        }
        static void DecodeString(string codedText)
        {
            string[] codeWords = codedText.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder uncoded = new StringBuilder("");

            foreach (string codeWord in codeWords)
            {
                try
                {
                    int idx = dictionary.Codes.IndexOf(codeWord);
                    uncoded.Append(dictionary.Symbols[idx]);
                }
                catch
                {
                    Console.WriteLine("GG");
                }
                
            }

            Console.WriteLine(uncoded);
        }
    }
}
