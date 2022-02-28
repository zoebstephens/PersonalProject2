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
    }
}
