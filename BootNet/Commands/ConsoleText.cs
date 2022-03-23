using System;

namespace BootNet.Commands
{
    internal class ConsoleText
    {
        public static void Clear()
        {
            Console.Clear();
        }
        public static void Echo()
        {
            Console.Write("Text to echo: ");
            var input = Console.ReadLine().ToLower();
            Console.WriteLine(input);
        }
    }
}
