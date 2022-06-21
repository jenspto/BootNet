using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BootNet.Graphics
{
    public class Canvas
    {
        public static void DrawCanvas()
        {
            Kernel.canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
            Kernel.canvas.Clear(Color.Black);
        }
        public static void DrawDesktop()
        {
            
        }
        public static void DrawTaskBar()
        {
            Pen pen = new(Color.DarkSlateGray);
            Kernel.canvas.DrawFilledRectangle(pen, 0, 0, 800, 25);
        }
    }
}
