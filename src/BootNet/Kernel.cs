using Cosmos.HAL;
using Cosmos.System.Graphics;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Drawing;
using Sys = Cosmos.System;

namespace BootNet
{
    public class Kernel : Sys.Kernel
    {
        public static Canvas canvas;
        readonly Pen white = new(Color.White);
        protected override void BeforeRun()
        {
            Graphics.Screen.DrawCanvas();
            Graphics.ASC16.DrawACSIIString(Kernel.canvas, white, "BootNet booted successfully", 0, 0);
        }

        protected override void Run()
        {
        }
    }
}
