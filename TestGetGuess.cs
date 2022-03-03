using System;

namespace PersonalProject2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            // Feedback(jcollard 2022-03-03): Great job on this test! Double check the 
            // flow chart for this method. It doesn't actually display the result of the 
            // users value. It should only validate that the value entered is valid. For
            // example, if the user types ing "chocolate", it shouldn't be valid because the
            // word "chocolate" is too long.
            Console.WriteLine($"Type in sleep. You should see a green S, and you should see a red L, E, E, P");
            string result = Program.GetGuess("stunt");
            string expected = "SLEEP";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'Sleep' but was {result}");
                return false;
            }
            Console.WriteLine($"Type in sugar. You should see a green S, //& a yellow U, and you should see a red G, A, R");
            result = Program.GetGuess("stunt");
            expected = "SUGAR";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'Sugar' but was {result}");
                return false;
            }
            Console.WriteLine($"Type in the word stunt. You should expect all the letters to be green");
            result = Program.GetGuess("stunt");

            Console.WriteLine($"Type in the word joke. You should see an error message due to the length of the word. Now type in jokes. You should see a green O, E, S //& a red J, K");
            string result2 = Program.GetGuess("cones");
            Console.WriteLine($"Type in the word kopes. You should see an error message due to the input of a nonexistent word. Now type boats. You should see a Green O, S //& a Red B, A, T ");
            result2 = Program.GetGuess("cones");
            Console.WriteLine($"Type in the word cones. You should expect all letters to be green.");
            result2 = Program.GetGuess("cones");

            Console.WriteLine($"Type in the word alone. You should see a green A, L, O, //& a red N, E");
            string result3 = Program.GetGuess("aloha");
            expected = "ALONE";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'ALONE' but was {result}");
                return false;
            }
            Console.WriteLine($"Type in the word aloha. You should expect all letters to be green.");
            result3 = Program.GetGuess("aloha");

            


            return false;
        }

    }

}