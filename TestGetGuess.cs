using System;

namespace PersonalProject2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            Console.WriteLine($"Type in sleep. You should see a green S, and you should see a red L, E, E, P");
            string input = Program.GetGuess("stunt");
            Console.WriteLine($"Type in sugar. You should see a green S, //& a yellow U, and you should see a red G, A, R");
            input = Program.GetGuess("stunt");
            Console.WriteLine($"Type in the word stunt. You should expect all the letters to be green");
            input = Program.GetGuess("stunt");

            Console.WriteLine($"Type in the word joke. You should see an error message due to the length of the word. Now type in jokes. You should see a green O, E, S //& a red J, K");
            string input2 = Program.GetGuess("cones");
            Console.WriteLine($"Type in the word kopes. You should see an error message due to the input of a nonexistent word. Now type boats. You should see a Green O, S //& a Red B, A, T ");
            input2 = Program.GetGuess("cones");
            Console.WriteLine($"Type in the word cones. You should expect all letters to be green.")
            input2 = Program.GetGuess("cones");


            return false;
        }

    }

}