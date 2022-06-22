using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using Mouse = Cosmos.System.MouseManager;
using MouseState = Cosmos.System.MouseState;

namespace BootNet.Graphics
{
    public class Cursor
    {
        public static void DrawCursor()
        {
            Mouse.ScreenWidth = 800;
            Mouse.ScreenHeight = 600;
            Mouse.X = (uint)(Kernel.canvas.Mode.Columns / 2);
            Mouse.Y = (uint)(Kernel.canvas.Mode.Rows / 2);
        }
        public static void UpdateCursor()
        {
            try
            {
                Pen cursorcolor = new(Color.White);
                Kernel.canvas.DrawLine(cursorcolor, (int)Mouse.X, (int)Mouse.Y,
                    (int)Mouse.X + 6, (int)Mouse.Y);
                Kernel.canvas.DrawLine(cursorcolor, (int)Mouse.X, (int)Mouse.Y,
                    (int)Mouse.X, (int)Mouse.Y + 6);
                Kernel.canvas.DrawLine(cursorcolor, (int)Mouse.X, (int)Mouse.Y,
                (int)Mouse.X + 10, (int)Mouse.Y + 10);
                Kernel.canvas.Display();
                Kernel.canvas.Clear(Color.DarkBlue);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: " + e.Message);
                Sys.Power.Shutdown();
            }
        }
    }
}
