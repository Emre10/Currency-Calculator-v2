using System;

namespace Exchange
{
    class Print
    {
        public static void WriteScreen(string [] data)
        {
            foreach (string pie in data)
            {
                Console.WriteLine(pie);
            }
        }
    }
}
