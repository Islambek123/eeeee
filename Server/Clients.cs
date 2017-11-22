using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Server;
using System.Net;
using DrawMatrixDLL;
using SendBytesToClient;

namespace serverChat
{
    public class Client
    {
        private string _userName;
        private Socket _handler;
        private Thread _userThread;
        private EFContext context;
        byte[] ByteMap { get; set; }
        public Client(Socket socket)
        {
            _handler = socket;
            _userThread = new Thread(Listner);
            _userThread.IsBackground = true;
            _userThread.Start();
            ByteMap = ReadMatrixFromDb();
        }
        public string UserName
        {
            get { return _userName; }
        }
        private void Listner()
        {
            while (true)
            {
                try
                {
                    if (_handler.ReceiveBufferSize != 0)
                    {
                        var binFormatter = new BinaryFormatter();
                        MemoryStream ms = new MemoryStream();

                        byte[] buffer = new byte[_handler.ReceiveBufferSize];
                        int count = _handler.Receive(buffer);
                        byte[] result = new byte[count];

                        for (int i = 0; i < count; i++)
                            result[i] = buffer[i];

                        SendMatrixToDb(result, "default");
                        End();
                    }
                    else if()
                    {

                    }
                    
                }
                
                catch { Server.EndClient(this); return; }
            }
        }

        private void handleCommand(string data)
        {
            if (data.Contains("#setname"))
            {
                _userName = data.Split('&')[1];
                UpdateChat();
                return;
            }
            if (data.Contains("#newmsg"))
            {
                string message = data.Split('&')[1];
                ChatController.AddMessage(_userName, message);
                return;
            }
        }
        public void UpdateChat()
        {
            Send(ChatController.GetChat());
        }
        public void Send(string command)
        {
            try
            {
                int bytesSent = _handler.Send(Encoding.UTF8.GetBytes(command));
                if (bytesSent > 0) Console.WriteLine("Success");
            }
            catch (Exception exp) { Console.WriteLine("Error with send command: {0}.", exp.Message); Server.EndClient(this); }
        }
        public void End()
        {
            try
            {
                _handler.Close();
                try
                {
                    _userThread.Abort();
                }
                catch { } // г
            }
            catch (Exception exp) { Console.WriteLine("Error with end: {0}.", exp.Message); }
        }
        
        public void SendMatrixToDb(byte[] _bmap, string mapName)
        {
            Map map = new Map();
            context = new EFContext();
            map.MapToByte = _bmap;
            map.MapName = mapName;

            context.Maps.Add(map);

            context.SaveChanges();
        }

        public byte[] ReadMatrixFromDb()
        {
            context = new EFContext();
            byte[]bmap = new byte[100000];

            foreach(var map in context.Maps.ToList())
            {
                bmap = map.MapToByte;
            }
            return bmap;
        }
        public void SendMapToClient()
        {
            SendFromHost sendFromHost = new SendFromHost(_handler);
            sendFromHost.SendBytesToClient(ByteMap);
        }
    }
}
