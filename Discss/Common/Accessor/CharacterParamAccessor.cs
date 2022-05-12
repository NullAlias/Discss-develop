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
    class CharacterParamAccessor
    {
        private static string xmlPath = DirectoryAccessor.CharacterXml;

        private static CharacterParent prpCharacterParent = GetCharacter();

        public static CharacterParent Characters
        {
            get
            {
                return prpCharacterParent;
            }
        }
        private static CharacterParent GetCharacter()
        {
            if (!File.Exists(xmlPath)) return new CharacterParent();
            try
            {
                // デシリアライズする
                var xmlSerializer2 = new XmlSerializer(typeof(CharacterParent));
                CharacterParent result;
                var xmlSettings = new System.Xml.XmlReaderSettings()
                {
                    CheckCharacters = false,
                };
                using (var streamReader = new StreamReader(xmlPath, Encoding.UTF8))
                using (var xmlReader
                        = System.Xml.XmlReader.Create(streamReader, xmlSettings))
                {
                    result = (CharacterParent)xmlSerializer2.Deserialize(xmlReader);
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public static void SetCharacter()
        {
            try
            {
                // シリアライズする
                var xmlSerializer1 = new XmlSerializer(typeof(CharacterParent));
                using (var streamWriter = new StreamWriter(xmlPath, false, Encoding.UTF8))
                {
                    xmlSerializer1.Serialize(streamWriter, prpCharacterParent);
                    streamWriter.Flush();
                }
            }
            catch(Exception e)
            {
                string m = e.Message;
            }
        }
    }
}
