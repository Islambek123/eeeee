using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SendBytesToClient
{
    public class SendFromHost
    {
        private Socket _socket;
        private Thread _thread;
        public SendFromHost(Socket socket)
        {
            _socket = socket;
        }

        public void SendBytesToClient(byte[] mass)
        {
            _socket.Send(mass);
        }
    }
}
