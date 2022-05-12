using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discss.Common.Accessor
{
    class DirectoryAccessor
    {
        public static string RootDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName);
        public static string ImageDir = Path.Combine(RootDir, Properties.Settings.Default.ImageDirName);
        public static string ServerXml = Path.Combine(RootDir, Properties.Settings.Default.ServerXmlName);
        public static string CharacterXml = Path.Combine(RootDir, Properties.Settings.Default.CharacterXmlName);
        public static string SettingXml = Path.Combine(RootDir, Properties.Settings.Default.SettingXmlName);

        static DirectoryAccessor()
        {
            if (!Directory.Exists(RootDir))
            {
                Directory.CreateDirectory(RootDir);
            }

            if (!Directory.Exists(ImageDir))
            {
                Directory.CreateDirectory(ImageDir);
                Properties.Resources._default.Save(Path.Combine(ImageDir, "default.png"));
            }
        }
    }
}
