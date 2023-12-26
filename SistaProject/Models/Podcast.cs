using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Models
{
    public class Podcast : TitleE
    {

        [XmlIgnore]
        public Timer timer = new Timer();

        public List<Episode> EpisodeList = new List<Episode>();
        public string Url { get; set; }
        public string NumberOfEpisode { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public string UpdateFrequency { get; set; }

     }
}
