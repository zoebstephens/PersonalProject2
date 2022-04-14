using System;

namespace PersonalProject2
{
    class TestDisplayInfo
    {
        public static bool RunTest()
        {
            Console.WriteLine($"You should expect to see a green Y, and you should see a red P, I, C, K");
            Program.DisplayInfo("picky", "crazy");

            Console.WriteLine($"You should expect to see a Yellow R, A, //& you should see a Green Y and you should see a red I, N");
            Program.DisplayInfo("rainy", "crazy");

            Console.WriteLine($"You should expect to see a Green R, A, //& a Red T, I, N");
            Program.DisplayInfo("train", "crazy");

            Console.WriteLine($"You should expect to see a green C, R, A, Z, Y");
            Program.DisplayInfo("crazy", "crazy");


            return false;
        }

    }

}