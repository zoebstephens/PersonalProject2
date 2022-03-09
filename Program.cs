using System;
using System.Collections.Generic;

namespace PersonalProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument 
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }
            // otherwise the program continues executing
            string correct = GetRandomWord();
            string guess = "";
            while (guess != correct)
            {
                guess = GetGuess(correct);
                DisplayInfo(guess, correct);
                Console.WriteLine();
            }
            Console.WriteLine($"You won!");
        

        }


        public static void TestAll()
        {
            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"Test DisplayCharInfo(correct): {testDisplayCharInfo}");

            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"Test DisplayInfo(correct): {testDisplayInfo}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"Test GetGuess(correctWord): {testGetGuess}");



        }
        public static string GetRandomWord()
        {
            List<string> words = new List<string>();
            words.Add("candy");
            words.Add("roach");
            words.Add("ready");
            words.Add("ahead");
            words.Add("reach");
            words.Add("break");
            words.Add("glass");
            words.Add("chart");
            words.Add("truth");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
        
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }

        public static string GetGuess(string correctWord)
        {
            // Prompt the user to make a guess
            // Read input from the keyboard and store the results in a variable named guess
            // If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.

            string input;

            do
            {
                Console.Write("Enter a guess that is 5 letters long:");
                input = Console.ReadLine();


                if (input.Length != 5)
                {
                    Console.Error.WriteLine("That guess is not 5 letters long");
                }
            }
            while (input.Length != 5);

            return input;

        }

        public static void DisplayInfo(string guess, string correct)
        {
            if (guess == null)
            {
                throw new ArgumentNullException("Guess can not be null");

            }

            if (guess.Length != correct.Length)
            {
                throw new ArgumentException("The guess must be the same length as the correct word");
            }


            int ix = 0;
            foreach (char c in guess)
            {
                DisplayCharInfo(c, ix, correct);
                ix = ix + 1;

            }
            // Validate that the guess and correct word are the same length
            // If the lengths do not match, throw an exception
            // If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }

        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            if (guess == correct[pos])
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (correct.Contains(guess))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(guess);
            Console.ForegroundColor = ConsoleColor.White;

        }


    }
}
