using BootNet.Graphics;
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
        public static Sys.Graphics.Canvas canvas;
        protected override void BeforeRun()
        {
            Graphics.Desktop.DrawCanvas();
            Cursor.DrawCursor();
            Commands.Filesystem.Start();
        }
        protected override void Run()
        {
            Cursor.UpdateCursor();
            Graphics.Desktop.DrawTaskBar();
        }
    }
}