/*
 * Author: Matthew Tan
 * Course: COMP003A
 * Purpose: Week 7 Assignment
 * 
 */ 


namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter");
            Console.WriteLine("Please enter a letter: ");
            char characterInput = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();
            int charCount = CharacterCounter(characterInput, word);
            Console.WriteLine($"There are {charCount} letter {characterInput} in the word {word}.");

            SectionSeparator("Array - IsPalindrome");
            Console.WriteLine("");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            word = Convert.ToString(Console.ReadLine());
            bool input = IsPalindrome(word);
            if (input == true)
            {
                Console.WriteLine($"Is the word {word} palindrome: True");
            }
            else
            {
                Console.WriteLine($"Is the word {word} palindrome: False");
            }

            SectionSeparator("List - Add");
            List<string> names = new List<string>();
            string userInput = default;
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Please enter a name");
                names.Add(Console.ReadLine());
                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Console.ReadLine();
                Console.WriteLine("");
            } while (userInput != "e");

            SectionSeparator("List - Traversal");
            TraverseList(names);

            SectionSeparator("List - Reverse Traversal");
            TraverseListReverse(names);
        }
  
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t{section} Section\n" + "".PadRight(50, '*'));
        }

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            int charCount = 0;
            char inputChar = Char.ToLower(characterInput);
            word = word.ToLower();
            foreach (char c in word)
            {
                char charCheck = Char.ToLower(word[count]);
                if (charCheck == inputChar)
                {
                    charCount++;
                    count++;
                }
                else count++;
            }
            return charCount;
        }

        static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            if (word == reversedWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TraverseList(List<string> list)
        {
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            list.Reverse();
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}