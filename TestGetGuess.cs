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
            Console.WriteLine($"Type in sleep.");
            string result = Program.GetGuess("stunt");
            string expected = "SLEEP";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'Sleep' but was {result}");
                return false;
            }
            
            Console.WriteLine($"Type in sugar.");
            result = Program.GetGuess("sugar");
            expected = "SUGAR";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'Sugar' but was {result}");
                return false;
            }

            Console.WriteLine($"Type in the word joke. You should see an error message due to the length of the word being too short.");
            Console.WriteLine($"Type in the word cones.");
            result = Program.GetGuess("cones");
            expected = "CONES";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'Cones' but was {result}");
                return false;
            }

            Console.WriteLine($"Type in the word project.You should see an error message due to the length of the word being too long.");
            Console.WriteLine($"Type in the word aloha.");
            string result3 = Program.GetGuess("aloha");
            expected = "ALOHA";
            if (result != expected){
                Console.Error.WriteLine($"Expected result to be 'ALOHA' but was {result}");
                return false;
            }

            return false;
        }

    }

}