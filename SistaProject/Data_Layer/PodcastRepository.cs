using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data_Layer
{
    public class PodcastRepository
    {
        public static void SavePodcasts(List<Podcast> podcastList)
        {
            PodcastSerialization.SavePodcasts(podcastList);
        }
        public static List<Podcast> GetPodcasts1()
        {
            return PodcastSerialization.GetPodcasts1();
        }
    }
}
