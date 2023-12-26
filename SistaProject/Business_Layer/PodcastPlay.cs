using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Business_Layer
{
    public class PodcastPlay
    {
        public static void SetEpisode(Models.Podcast podcast, XmlNodeList episodeList)
        {
            podcast.EpisodeList.Clear();

            foreach (XmlNode xmlEpisode in episodeList)
            {
                var episode = new Models.Episode();
                episode.Title = xmlEpisode.SelectSingleNode("title").InnerText;
                episode.Description = xmlEpisode.SelectSingleNode("description").InnerText;
                podcast.EpisodeList.Add(episode);
            }
        }
        
        public static int UpdatesInMillisecondIntervals(string UpdateFrequency)
        {
            if (UpdateFrequency == "Every 10 minutes")
            {
                return 600000;
            }
            if (UpdateFrequency == "Every 20 minutes")
            {
                return 1200000;
            }
            if (UpdateFrequency == "Every 30 minutes")
            {
                return 1800000;
            }
            if (UpdateFrequency == "Every 60 minutes")
            {
                return 3600000;
            }
            throw new Exception("Did not find the update frequency");
        }

    }
}
