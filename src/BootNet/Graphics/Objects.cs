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
            Drivers.ASC16.DrawACSIIString(Kernel.canvas, textcolor, s, x, y);
        }
    }
}
