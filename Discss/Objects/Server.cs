using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discss.Objects
{
    public class ServerParent
    {
        //ArrayListに追加される型を指定する
        [System.Xml.Serialization.XmlArrayItem(typeof(Server)),System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList server;
    }

    public class Server
    {
        public string server_id;
        public string server_name;
        [System.Xml.Serialization.XmlArrayItem(typeof(ChatChannel)), System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList chat_channel;

        public Server()
        {
            server_id = "";
            server_name = "Empty";
            chat_channel = new System.Collections.ArrayList();
        }

        public Server(string id, string name, System.Collections.ArrayList channel)
        {
            server_id = id;
            server_name = name;
            chat_channel = channel;
        }

        public void AddChannel(ChatChannel channel)
        {
            if(chat_channel == null)
            {
                chat_channel = new System.Collections.ArrayList();
            }
            chat_channel.Add(channel);
        }
    }

    public class ChatChannel
    {
        public string channel_id;
        public string channel_name;

        public ChatChannel()
        {
            channel_id = "";
            channel_name = "Empty";
        }

        public ChatChannel(string id, string name)
        {
            channel_id = id;
            channel_name = name;
        }
    }
}
