﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctioalProgramming
{
    public class VowelAndConsonant
    {
        public static void CheckTheCharacter()
        {
            char ch;

            Console.WriteLine("Enter any character:");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
               ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is Consonant");
            }
            else
            {
                Console.WriteLine(ch + " is not an alphabet");
            }
        }
    }
}
