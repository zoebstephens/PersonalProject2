using System;

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
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return null;
        }

        public static string GetGuess(string correctWord)
        {
            // Prompt the user to make a guess
            // Read input from the keyboard and store the results in a variable named guess
            // If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
            return null;
        }

        public static string DisplayInfo(string guess, string correct)
        {
            // Validate that the guess and correct word are the same length
            // If the lengths do not match, throw an exception
            // If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
            return null;
        }

        public static string DisplayCharInfo(char guess, int pos, string correct)
        {
            // If the guess is in the correct position, select the color green.
            // If the guess is in the correct word but not correct position, select yellow.
            // If the guess is not in the correct word, select red.
            // Display the guess
            // Reset the color back to white before returning
            return null;
        }


    }
}
