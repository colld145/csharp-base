using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _02._String
{
    class Program
    {
        static void Main()
        {
            /*Task 1:
               Вставити в задану позицію рядка інший рядок.*/

            /*string str = "hello world";

            string new_str = " wonderful";

            Console.WriteLine("Enter a position:");
            int pos = int.Parse(Console.ReadLine());

            string inserted_str = str.Insert(pos, new_str);
            Console.WriteLine(inserted_str);*/
            
            // -----------------------------------------
            
            /*Визначити, чи є рядок паліндромом.
             Паліндром – це число, слово або фраза, яка однаково читається в обох напрямках.*/

            /*string str = "11aa11";
            bool non_palindrome = false;
            for (int i = 0, j = str.Length - 1; i < (str.Length / 2); i++, j--)
            {
                char start = str[i];
                char end = str[j];
                if (start != end)
                    non_palindrome = true;
            }

            bool is_palindrome = non_palindrome == false;
            Console.WriteLine("Line is palindrome: " + is_palindrome);*/
            
            // -----------------------------------------------------
            
            /*Дано текст. Визначте відсоткове відношення малих
             і великих літер до загальної кількості символів в ньому.*/

            /*string text = "Hello World! World, hello. WWorld HELLO.";

            int upper_count = 0;
            int lower_count = 0;

            foreach (var ch in text)
            {
                if (char.IsUpper(ch))
                    upper_count++;
                if (char.IsLower(ch))
                    lower_count++;
            }

            int size = text.Length;
            float upper_percentage = (upper_count * 100) / size;
            float lower_percentage = (lower_count * 100) / size;
            
            Console.WriteLine("Upper percentage: " + upper_percentage + " %");
            Console.WriteLine("Lower percentage: " + lower_percentage + " %");*/
            
            // ----------------------------------------
            
            /*Дано масив слів. Замінити останні три символи слів,
             що мають обрану довжину, на символ "$".*/

            string[] dict = { "Hello", "World", "Hold", "On", "Olleh", "Dlrow"};
            
            Console.WriteLine("Enter a word length:");
            int l = int.Parse(Console.ReadLine());
            
            foreach (var word in dict)
            {
                if (word.Length == l)
                {
                    // ...
                }
                    
            }
            
            foreach (var word in dict)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            
            
        }
    }
}
