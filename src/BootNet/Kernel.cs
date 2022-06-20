using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Drawing;
using System.IO;
using Sys = Cosmos.System;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Graphics.Canvas.DrawCanvas();
            Graphics.Canvas.DrawCursor();
        }
        
        protected override void Run()
        {
            Graphics.Canvas.UpdateCursor();
        }
    }
}
