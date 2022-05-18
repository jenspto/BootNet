using Cosmos.HAL;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
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
        public static void DHCP()
        {
            using var xClient = new DHCPClient();
            xClient.SendDiscoverPacket();
            NetworkDevice nic = NetworkDevice.GetDeviceByName("eth0");
            IPConfig.Enable(nic, new Address(192, 168, 1, 69), new Address(255, 255, 255, 0), new Address(192, 168, 1, 254));
        }
    }
}
