using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class ConsonentVowel
    {
        public void FindVowelConsonant()
        {
            char V;
            Console.WriteLine("Enter any character");
            V = Convert.ToChar(Console.ReadLine());

            switch (V)
            {
                case 'A': Console.WriteLine("Alphabet is vowel"); break;
                case 'a': Console.WriteLine("Alphabet is vowel"); break;
                case 'E': Console.WriteLine("Alphabet is vowel"); break;
                case 'e': Console.WriteLine("Alphabet is vowel"); break;
                case 'I': Console.WriteLine("Alphabet is vowel"); break;
                case 'i': Console.WriteLine("Alphabet is vowel"); break;
                case 'O': Console.WriteLine("Alphabet is vowel"); break;
                case 'o': Console.WriteLine("Alphabet is vowel"); break;
                case 'U': Console.WriteLine("Alphabet is vowel"); break;
                case 'u': Console.WriteLine("Alphabet is vowel"); break;
                default: Console.WriteLine("You enter is consonant"); break;
            }
        }
    }
}
