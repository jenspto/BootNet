using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BootNet.Drivers
{
    public class ErrorScreen
    {
        
        public static String ErrorText;
        public static void Panic()
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("An exception has occurred: " + ErrorText);
        }
    }
}
