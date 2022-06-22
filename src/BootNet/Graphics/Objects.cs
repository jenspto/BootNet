using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cosmos.System.Graphics;

namespace BootNet.Graphics
{
    public class Objects
    {
        public static void DrawButton(Pen backgroundcolor, Pen textcolor, int x, int y, String s)
        {
            Kernel.canvas.DrawFilledRectangle(backgroundcolor, x, y, 100, 16);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s, x, y);
        }
        public static void DrawMenu(Pen backgroundcolor, Pen textcolor, int x, int y, String s1, String s2, String s3, String s4, String s5)
        {
            Kernel.canvas.DrawFilledRectangle(backgroundcolor, x, y, 100,80);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s1, x, y);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s2, x, y + 16);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s3, x, y + 32);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s4, x, y + 48);
            ASC16.DrawACSIIString(Kernel.canvas, textcolor, s5, x, y + 64);
        }
    }
}
