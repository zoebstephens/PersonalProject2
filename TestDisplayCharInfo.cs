using System;

namespace PersonalProject2
{
    class TestDisplayCharInfo
    {
        public static bool RunTest()
        {
            Program.DisplayCharInfo('s', 2, "smile");
            Console.WriteLine($"You should expect to see a yellow S");

            Program.DisplayCharInfo('j', 1, "juice");
            Console.WriteLine($"You should expect to see a green A");

            Program.DisplayCharInfo('i', 3, "pants");
            Console.WriteLine($"You should expect to see a red I");
            
            return false;
        }

    }

}