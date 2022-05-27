using BootNet.Drivers;
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
        Canvas canvas;
        protected override void BeforeRun()
        {
            Console.WriteLine("BootNet booted successfully!");
            try
            {
                canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
                canvas.Clear(Color.Green);


                Sys.MouseManager.ScreenWidth = 800;
                Sys.MouseManager.ScreenHeight = 600;

                Sys.MouseManager.X = (uint)((int)canvas.Mode.Columns / 2);
                Sys.MouseManager.Y = (uint)((int)canvas.Mode.Rows / 2);
            }
            catch(Exception e)
            {
                ErrorScreen.ErrorText = e;
                ErrorScreen.Panic();
            }
        }

        protected override void Run()
        {
            try
            {

                Pen white = new Pen(Color.White);

                canvas.DrawLine(white, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X + 6, (int)Cosmos.System.MouseManager.Y);
                canvas.DrawLine(white, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y + 6);
                canvas.DrawLine(white, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X + 12, (int)Cosmos.System.MouseManager.Y + 12);

                canvas.Display();
                canvas.Clear(Color.Black); 
            }
            catch (Exception e)
            {
                ErrorScreen.ErrorText = e;
                ErrorScreen.Panic();
            }
        }
        protected override void AfterRun()
        {
            
        }
        protected override void OnBoot()
        {
            Console.Clear();
            Console.WriteLine("Booting...");
        }
    }
}
