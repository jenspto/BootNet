using Cosmos.System.Graphics;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using Sys = Cosmos.System;


namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        public static Canvas canvas;
        protected override void BeforeRun()
        {
            Graphics.Canvas.DrawCanvas();
            Drivers.Cursor.DrawCursor();
            Commands.Filesystem.Start();
        }
        protected override void Run()
        {
            Drivers.Cursor.UpdateCursor();
            Graphics.Canvas.DrawTaskBar();
            Graphics.Canvas.DrawXY();
        }
    }
}