using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BootNet.Commands
{
    public class Messages
    {
        public static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Command not found.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void HelpMessage()
        {
            Console.WriteLine("=====Commands=====");
            
        }
        public static void NetMessage()
        {
            Console.WriteLine("Network connected. Your ip is: "); Network.WriteIp();
            
        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
