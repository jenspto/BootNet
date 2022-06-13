using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootNet.Commands
{
    public class Network
    {
        
        public static void Connect()
        {
            try
            {
                using (var xClient = new DHCPClient())
                {
                    xClient.SendDiscoverPacket();
                    Messages.NetMessage();
                }
            }
            catch(Exception e)
            {
                Drivers.ErrorScreen.ErrorText = e.ToString();
                Drivers.ErrorScreen.Panic();
            }
        }
        public static void WriteIp()
        {
            Console.Write(NetworkConfiguration.CurrentAddress.ToString());
        }
    }
}
