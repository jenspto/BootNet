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

namespace BootNet.Drivers
{
    public class Cursor
    {
        public static void DrawCursor()
        {
            Sys.MouseManager.ScreenWidth = 800;
            Sys.MouseManager.ScreenHeight = 600;
            Sys.MouseManager.X = (uint)((int)Kernel.canvas.Mode.Columns / 2);
            Sys.MouseManager.Y = (uint)((int)Kernel.canvas.Mode.Rows / 2);
        }
        public static void UpdateCursor()
        {
            try
            {

                Pen cursorcolor = new(Color.White);
                Kernel.canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X + 6, (int)Cosmos.System.MouseManager.Y);
                Kernel.canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y + 6);
                Kernel.canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                (int)Cosmos.System.MouseManager.X + 10, (int)Cosmos.System.MouseManager.Y + 10);
                Kernel.canvas.Display();
                Kernel.canvas.Clear(Color.Black);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: " + e.Message);
                Sys.Power.Shutdown();
            }
        }
    }
}
