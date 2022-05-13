using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BootNet booted successfully.");
            Console.ForegroundColor = ConsoleColor.White;
            RedScreen.ErrorText = "Error: rebooting...";
            RedScreen.DisplayRedScreen();
        }

        protected override void Run()
        {
            
        }
    }
}
