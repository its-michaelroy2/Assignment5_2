using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace Assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment5.2.1");
            Console.WriteLine("===============\n");

            Console.WriteLine("Please type in a phrase and we will tell you the length of the last word: ");
            string phrase = Console.ReadLine();
            Console.WriteLine($"\nThe length of the last word is: {LengthOfLastWord(phrase)}\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Assignment5.2.2");
            Console.WriteLine("===============\n");

            Console.WriteLine("How many numbers to print: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            recursion(1, n);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Assignment5.2.3");
            Console.WriteLine("===============\n");

            Console.Write("Please type in a number where you want to start and go to 1: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\n{number} to 1: ");
            fromMaxNumTo1(number);
            Console.WriteLine("\n");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Assignment5.2.4");
            Console.WriteLine("===============\n");

            Console.Write("Please type in a string to check whether it is a plaindrome: ");
            string characters = Console.ReadLine();
            Console.WriteLine($"\nIs {characters} a plaindrome? {IsPalindrome(characters)}\n");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        static int LengthOfLastWord(string s)
        {
            // Trim any trailing spaces
            s = s.TrimEnd();

            // Find the last space in string
            int lastSpaceIndex = s.LastIndexOf(' ');

            // If no space the entire string is the last word
            if (lastSpaceIndex == -1)
            {
                return s.Length;
            }

            // Return the length of the substring after the last space
            return s.Length - lastSpaceIndex - 1;
        }

        static void recursion(int currentNumber, int maxNumber)
        {
            if (currentNumber <= maxNumber)
            {
                Console.Write($"{currentNumber} ");
                recursion(currentNumber + 1, maxNumber);
            }
        }

        static void fromMaxNumTo1(int n)
        {
            if (n >= 1)
            {
                Console.Write($"{n} ");
                fromMaxNumTo1(n - 1);
            }
        }

        static bool IsPalindrome(string characters)
        { //Rereading I realized i couldve just returned a string that states "The string is a palindrome if true, otherwise just say is NOT"

            {
                // Base case: if the string is empty or has only one character, it's a palindrome
                if (characters.Length <= 1)
                    return true;

                // Check if the first and last characters are the same
                if (char.ToLower(characters[0]) != char.ToLower(characters[characters.Length - 1]))
                    return false;

                // GOLD: Recursively check the substring without the first and last characters
                return IsPalindrome(characters.Substring(1, characters.Length - 2));
            }
        }
    }
}
