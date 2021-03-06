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
    public static class SettingParamAccessor
    {
        private static string xmlPath = DirectoryAccessor.SettingXml;

        private static SettingParent prpSettingParent = GetSetting();

        public static SettingParent Settings
        {
            get
            {
                return prpSettingParent;
            }
        }
        private static SettingParent GetSetting()
        {
            if (!File.Exists(xmlPath)) return new SettingParent();
            try
            {
                // デシリアライズする
                var xmlSerializer2 = new XmlSerializer(typeof(SettingParent));
                SettingParent result;
                var xmlSettings = new System.Xml.XmlReaderSettings()
                {
                    CheckCharacters = false, 
                };
                using (var streamReader = new StreamReader(xmlPath, Encoding.UTF8))
                using (var xmlReader
                        = System.Xml.XmlReader.Create(streamReader, xmlSettings))
                {
                    result = (SettingParent)xmlSerializer2.Deserialize(xmlReader);
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public static void SetSetting()
        {
            try
            {
                // シリアライズする
                var xmlSerializer1 = new XmlSerializer(typeof(SettingParent));
                using (var streamWriter = new StreamWriter(xmlPath, false, Encoding.UTF8))
                {
                    xmlSerializer1.Serialize(streamWriter, prpSettingParent);
                    streamWriter.Flush();
                }
            }
            catch
            {

            }
        }

    }
}
