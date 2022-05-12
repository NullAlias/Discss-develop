using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Discss.Objects;

namespace Discss.Common.Accessor
{
    class ServerParamAccessor
    {
        private static string xmlPath = DirectoryAccessor.ServerXml;

        private static ServerParent prpServerParent = GetServer();

        public static ServerParent Servers
        {
            get
            {
                return prpServerParent;
            }
        }
        private static ServerParent GetServer()
        {
            if (!File.Exists(xmlPath))
            {
                ServerParent sp = new ServerParent();
                sp.server = new System.Collections.ArrayList();
                return sp;
            }
            try
            {
                // デシリアライズする
                var xmlSerializer2 = new XmlSerializer(typeof(ServerParent));
                ServerParent result;
                var xmlSettings = new System.Xml.XmlReaderSettings()
                {
                    CheckCharacters = false,
                };
                using (var streamReader = new StreamReader(xmlPath, Encoding.UTF8))
                using (var xmlReader
                        = System.Xml.XmlReader.Create(streamReader, xmlSettings))
                {
                    result = (ServerParent)xmlSerializer2.Deserialize(xmlReader);
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public static void SetServer()
        {
            try
            {
                // シリアライズする
                var xmlSerializer1 = new XmlSerializer(typeof(ServerParent));
                using (var streamWriter = new StreamWriter(xmlPath, false, Encoding.UTF8))
                {
                    xmlSerializer1.Serialize(streamWriter, prpServerParent);
                    streamWriter.Flush();
                }
            }
            catch
            {

            }
        }
    }
}
