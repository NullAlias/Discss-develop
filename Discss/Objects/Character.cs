using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discss.Objects
{
    public class CharacterParent
    {
        [System.Xml.Serialization.XmlArrayItem(typeof(Character)), System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList character;
    }
    public class Character
    {
        public string char_id;
        public string char_name;
        [System.Xml.Serialization.XmlArrayItem(typeof(CharacterImage)), System.Xml.Serialization.XmlArrayItem(typeof(string))]
        public System.Collections.ArrayList char_image;

        public Character()
        {
            char_id = "";
            char_name = "Empty";
            char_image = new System.Collections.ArrayList();
        }

        public Character(string id, string name)
        {
            char_id = id;
            char_name = name;
            char_image = new System.Collections.ArrayList();
        }

    }

    public class CharacterImage
    {
        public string image_id;
        public string image_name;
        public bool is_use = false;

        public CharacterImage()
        {
            image_id = GetUuid();
            image_name = "Empty";
            is_use = false;
        }

        public CharacterImage(string name, bool is_use=false)
        {
            this.image_id = GetUuid();
            this.image_name = name;
            this.is_use = is_use;
        }

        private string GetUuid()
        {
            Guid guidValue = Guid.NewGuid();
            return guidValue.ToString();
        }
    }
}
