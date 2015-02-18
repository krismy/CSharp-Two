using System;
using System.Linq;

class EnglishDigit
{
    static void Main()
    {
        //•	Write a method that returns the last digit of given integer as an English word.

        Console.Write("Enter integer number: ");
        string number = Console.ReadLine();
        char[] array = number.ToArray();
        char last = array[array.Length - 1];
        PrintWord(last);
    }

    private static void PrintWord(char last)
    {
        switch (last)
        {
            case '0':
                Console.WriteLine("Zero");
                break;
            case '1':
                Console.WriteLine("One");
                break;
            case '2':
                Console.WriteLine("Two");
                break;
            case '3':
                Console.WriteLine("Three");
                break;
            case '4':
                Console.WriteLine("Four");
                break;
            case '5':
                Console.WriteLine("Five");
                break;
            case '6':
                Console.WriteLine("Six");
                break;
            case '7':
                Console.WriteLine("Seven");
                break;
            case '8':
                Console.WriteLine("Eight");
                break;
            case '9':
                Console.WriteLine("Nine");
                break;

            default:
                Console.WriteLine("Wrong entry!");
                break;
        }
    }
}

