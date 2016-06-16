using System;
using System.IO;
using System.Xml.Serialization;

namespace _3.Paths
{
    public class Storage
    {
        public static void SavePath(string file, Path3D path)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                XmlSerializer serialized = new XmlSerializer(path.GetType());
                serialized.Serialize(sw, path);
            }
        }
        
        public static Path3D LoadPath(string text)
        {
            using (StreamReader sr = new StreamReader(text))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Path3D));
                return (Path3D)serializer.Deserialize(sr);
            }
        }
    }
}



