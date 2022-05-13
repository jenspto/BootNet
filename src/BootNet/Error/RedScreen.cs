using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootNet { } 
    public static class RedScreen
    {
        public static object ErrorText { get; set; }
    public static void DisplayRedScreen()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine(ErrorText);
    }
}
