using DrawMatrixDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToHostDLL
{
    public class ConnectToHost
    {
        public byte[] ListToByte { get; set; }
        private Socket _serverSocket;
        private const string _serverHost = "localhost";
        private const int _serverPort = 9933;

        public void GetMapToByte(List<RectangleGame> game)
        {
            var binFormatter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            binFormatter.Serialize(ms, game);
            ListToByte = ms.ToArray();
        }

        private void ConnectToHostMethod()
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(_serverHost);
                IPAddress ipAddress = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, _serverPort);
                _serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Connect(ipEndPoint);
            }
            catch { MessageBox.Show("Server Unable!"); }
        }

        public void SendMessageToHost()
        {
            try
            {
                if (ListToByte == null)
                    return;

                _serverSocket.Send(ListToByte);
            }
            catch { MessageBox.Show("Error"); }
        }
        public ConnectToHost()
        {
            ConnectToHostMethod();
        }
        public void End()
        {
            _serverSocket.Close();
            MessageBox.Show("Connection Lost!");
        }
    }
}
