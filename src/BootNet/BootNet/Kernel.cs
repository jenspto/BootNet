using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BootNet booted successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected override void Run()
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Command not found.");
                        Console.ForegroundColor = ConsoleColor.White;
                    } break;
                case "echo":
                    {
                        Console.Write("Text to echo: ");
                        var echo = Console.ReadLine();
                        Console.WriteLine(echo);
                    }
                    break;
            }
        }
    }
}
