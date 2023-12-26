using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Models;

namespace Data_Layer
{
    class PodcastSerialization
    {
        public static void SavePodcasts(List<Podcast> podcastList)
        {
            using (var writer = new StreamWriter("podcasts.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Podcast>));
                serializer.Serialize(writer, podcastList);
                writer.Flush();
            }
        }
        public static List<Podcast> GetPodcasts1()
        {
            if (File.Exists("podcasts.xml") == false)
            {
                return new List<Podcast>();
            }
            using (FileStream stream = File.OpenRead("podcasts.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<Podcast>));
                return serializer.Deserialize(stream) as List<Podcast>;
            }
        }
    }
}
