using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discss.Objects
{ 
    public class SettingParent
    {
        [System.Xml.Serialization.XmlArrayItem(typeof(Setting)), System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList setting;
    }
    public class Setting
    {
        public string id;
        public string name;
        public string server;
        public string chat_channel;
        [System.Xml.Serialization.XmlArrayItem(typeof(string)), System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList characters;

        public Setting()
        {
            id = GetUuid();
            name = "Empty";
            server = "";
            chat_channel = "";
            characters = new System.Collections.ArrayList();
        }

        public Setting(string name, string server, string chat_channel, System.Collections.ArrayList characters )
        {
            this.id = GetUuid();
            this.name = name;
            this.server = server;
            this.chat_channel = chat_channel;
            this.characters = characters;
        }

        private string GetUuid()
        {
            Guid guidValue = Guid.NewGuid();
            return guidValue.ToString();
        }
    }
}
