using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.TCP;
using Cosmos.System.Network.IPv4.TCP.FTP;
using Cosmos.System.Network.IPv4.UDP;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4.UDP.DNS;
using Sys = Cosmos.System;

namespace BootNet.Commands
{
    public static class Network
    {
        public static void IPv4()
        {
            NetworkDevice nic = NetworkDevice.GetDeviceByName("eth0"); //get network device by name
            IPConfig.Enable(nic, new Address(192, 168, 1, 69), new Address(255, 255, 255, 0), new Address(192, 168, 1, 254)); //enable IPv4 configuration
        }
        public static void DHCP()
        {
            using (var xClient = new DHCPClient())
            {
                /** Send a DHCP Discover packet **/
                //This will automatically set the IP config after DHCP response
                xClient.SendDiscoverPacket();
            }
        }
        public static void TCP()
        {
            using (var xServer = new TcpListener(4242))
            {
                /** Start server **/
                xServer.Start();

                /** Accept incoming TCP connection **/
                var client = xServer.AcceptTcpClient(); //blocking

                /** Stop server **/
                xServer.Stop();

                /** Send data **/
                client.Send(Encoding.ASCII.GetBytes(File.ReadAllText(@"0:\tcp.txt")));
            }
        }
        public static void FTP()
        {
            /** Initialize filesystem **/
            var fs = new CosmosVFS();
            VFSManager.RegisterVFS(fs);

            using (var xServer = new FtpServer(fs, "0:\\"))
            {
                /** Listen for new FTP client connections **/
                xServer.Listen();
            }
        }
        public static void UDP()
        {
            using (var xClient = new UdpClient(4242))
            {
                xClient.Connect(new Address(192, 168, 1, 70), 4242);

                /** Send data **/
                xClient.Send(Encoding.ASCII.GetBytes(File.ReadAllText(@"0:\udp.txt")));

                /** Receive data **/
                var endpoint = new EndPoint(Address.Zero, 0);
                var data = xClient.Receive(ref endpoint);  //set endpoint to remote machine IP:port
                var data2 = xClient.NonBlockingReceive(ref endpoint); //retrieve receive buffer without waiting
            }
        }
        public static void DNS()
        {
            using (var xClient = new DnsClient())
            {
                xClient.Connect(new Address(192, 168, 1, 254)); //DNS Server address

                /** Send DNS ask for a single domain name **/
                xClient.SendAsk(File.ReadAllText(@"0:\dns.txt"));

                /** Receive DNS Response **/
                Address destination = xClient.Receive(); //can set a timeout value
            }
        }
        public static void IP()
        {
            Console.WriteLine(NetworkConfig.CurrentConfig.Value.IPAddress.ToString());
        }
    }
}
