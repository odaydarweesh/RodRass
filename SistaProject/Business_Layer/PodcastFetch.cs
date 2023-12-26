using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class PodcastFetch
    {
        public static async Task<XmlDocument> FetchPodcastAsync(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "GET";
            using (WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    var document = new XmlDocument();
                    document.Load(stream);
                    return document;
                }
            }
        }
    }
}

