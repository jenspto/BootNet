using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootNet.Commands
{
    public class FTP
    {
        public static void Description()
        {
            using (var xClient = new DHCPClient())
            {
                xClient.SendDiscoverPacket();
            }
            String ip = NetworkConfig.CurrentConfig.Value.IPAddress.ToString();
            Console.WriteLine("ftpserver: Open a new ftp server located at " + ip + " .");
        }

    }
}
