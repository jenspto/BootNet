using System;
using Sys = Cosmos.System;


namespace BootNet
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully.");
            Console.Clear();
            Console.WriteLine(@" ___            _    _  _       _   ");
            Console.WriteLine(@"| _ ) ___  ___ | |_ | \| | ___ | |_ ");
            Console.WriteLine(@"| _ \/ _ \/ _ \|  _|| .  |/ -_)|  _|");
            Console.WriteLine(@"|___/\___/\___/ \__||_|\_|\___| \__|");
            Console.WriteLine("If you want to donate to the BootNet project, you can donate at http://ko-fi.com/ptobuon. 50% of my earnings will go to charity for Ukraine.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(c) 2022 Pto Buon. All rights reserved.");
            Console.WriteLine("Documentation: http://pto-buon.github.io/BootNet");
            Console.WriteLine("Source: http://github.com/pto-buon/BootNet");
        }


        protected override void Run()
        {
            Console.Write("root@" + pc + "$");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                default: Console.WriteLine("Bad command or file name."); break;
                case "": Console.WriteLine(); break;
                case "ftp": BootNet.Commands.FTP.Description(); break;
            }
        }
    }
}

