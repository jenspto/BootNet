using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IL2CPU.API.Attribs;
using Mouse = Cosmos.System.MouseManager;
using MouseState = Cosmos.System.MouseState;


namespace BootNet.Graphics
{
    public class Canvas
    {
        
        public static void DrawCanvas()
        {
            Kernel.canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
            Kernel.canvas.Clear(Color.Black);
            
        }
        public static void DrawTaskBar()
        {
            Kernel.canvas.DrawFilledRectangle(new Pen(Color.Blue), 0, 0, 800, 25);
            Graphics.Objects.DrawButton(new Pen(Color.Blue), new Pen(Color.White), 0, 0, "Start");
            if (Mouse.MouseState == MouseState.Left && Mouse.Y >= 0 && Mouse.X<=10)
            {
                Kernel.canvas.DrawFilledRectangle(new Pen(Color.White), 100, 25, 100, 100);
            }
        }
        public static void DrawWallpaper()
        {
        }
        public static void DrawXY()
        {
            Drivers.ASC16.DrawACSIIString(Kernel.canvas, new Pen(Color.White), Mouse.X + " " + Mouse.Y, 800, 600);
        }
    }
}
