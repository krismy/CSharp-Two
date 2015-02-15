using System;
using System.Linq;
//•	Write a program that creates an array containing all letters from the alphabet (A-Z).
//•	Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        char[] array = new char[26];

        for (int i = 0; i < 26; i++)
        {
            array[i] = (char)('A' + i);
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToUpper();

        Console.WriteLine("Letter -> Index");
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i]== array[j])
                {
                    
                    Console.WriteLine(word[i] + "->" + j);
                }
            }
            
        }

    }
}

