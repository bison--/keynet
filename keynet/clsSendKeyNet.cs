using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace keynet
{
    public class clsSendKeyNet
    {
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;

        public int sendUdpPackets = 10;
        public Keys pressedKey;
        public UInt64 sendId = 0;

        // This method will be called when the thread is started.
        public void DoWork()
        {
            var Client = new UdpClient();
            var RequestData = Encoding.ASCII.GetBytes(pressedKey.ToString() + "|" + sendId.ToString());
            var ServerEp = new IPEndPoint(IPAddress.Any, 0);

            Client.EnableBroadcast = true;
            for (int i = 0; i < sendUdpPackets; i++)
            {
                if (_shouldStop)
                {
                    Console.WriteLine("STOPPING " + sendId.ToString());
                    break;
                }
                Console.WriteLine("SENDING " + i.ToString() + " ...");
                Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 8888));
            }

            //var ServerResponseData = Client.Receive(ref ServerEp);
            //var ServerResponse = Encoding.ASCII.GetString(ServerResponseData);
            //Console.WriteLine("Recived {0} from {1}", ServerResponse, ServerEp.Address.ToString());

            Client.Close();
        }


        public void RequestStop()
        {
            _shouldStop = true;
        }       
    }
}
