using System;

namespace PersonalProject2
{
    class TestDisplayInfo
    {
        public static bool RunTest()
        {
            Console.WriteLine($"You should see a green Y, and you should see a red P, I, C, K");
            Program.DisplayInfo("picky", "crazy");
            return false;
        }

    }

}