using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace BootNet.Graphics { 
    
    public class Canvas
    {
        public static void DrawCanvas()
        {
            KernelHelpers.canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
            KernelHelpers.canvas.Clear(Color.Black);
        }
        public static void DrawCursor()
        {
            Sys.MouseManager.ScreenWidth = 800;
            Sys.MouseManager.ScreenHeight = 600;
            Sys.MouseManager.X = (uint)((int)KernelHelpers.canvas.Mode.Columns / 2);
            Sys.MouseManager.Y = (uint)((int)KernelHelpers.canvas.Mode.Rows / 2);
        }
        public static void UpdateCursor()
        {

        }
    }
}
