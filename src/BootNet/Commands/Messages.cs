using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("help: Show this message");
            Console.WriteLine("cat: Edit a file");
            Console.WriteLine("cr: Create a file");
            Console.WriteLine("del: Delete a file");
            Console.WriteLine("view: View a file");
            Console.WriteLine("net: Connect to the network");
            Console.WriteLine("su: Login as super user (root)");
            Console.WriteLine("ip: View the current ip address");
            Console.WriteLine("ftpserver: Make this session as a FTP server.");
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
