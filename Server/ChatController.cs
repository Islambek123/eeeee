using DrawMatrixDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Server;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serverChat
{
    public static class ChatController
    {
        private const int _maxMessage = 100;
        public static List<message> Chat = new List<message>();
        //static EFContext context;

        public struct message
        {
            public string data;

            public message(string msg)
            {
                data = msg;
            }
        }
        public static void AddMessage(string userName, string msg)
        {
            try
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(msg)) return;
                int countMessages = Chat.Count;
                if (countMessages > _maxMessage) ClearChat(); //якщо, кількість повідомлень в чаті > 100, то очистка
                message newMessage = new message(msg);
                Chat.Add(newMessage);
                Console.WriteLine("New message from {0}.");
                Server.UpdateAllChats();
            }
            catch (Exception exp) { Console.WriteLine("Error with addMessage: {0}.", exp.Message); }
        }

        //public static void SendMatrixToDb(byte[] mapToByte)
        //{
        //    Map map = new Map();
        //    context = new EFContext();

        //    map.MapToByte = mapToByte;
        //    context.Maps.Add(map);

        //    context.SaveChanges();
        //}
        
        public static void ClearChat()
        {
            Chat.Clear();
        }

        public static string GetChat()
        {
            try
            {
                string data = "#updatechat&";
                int countMessages = Chat.Count;

                if (countMessages <= 0)
                {
                    return string.Empty;
                }
                for (int i = 0; i < countMessages; i++)
                {
                    data += String.Format("{0}~{1}|", Chat[i].data);
                }
                return data;
            }
            catch (Exception exp) { Console.WriteLine("Error with getChat: {0}", exp.Message); return string.Empty; }
        }
    }
}
