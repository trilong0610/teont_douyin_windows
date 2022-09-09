using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouyinDownloader.Model
{
    public class ModelVideo
    {
        public string id { get; set; }
        public string desc { get; set; }
        public string author { get; set; }
        public Uri cover { get; set; }
        public double duration { get; set; }
        public int like { get; set; }

        public ModelVideo(string id, string desc, string author, Uri cover, double duration, int like = 0)
        {
            this.id = id;
            this.desc = desc;
            this.author = author;
            this.cover = cover;
            this.duration = duration;
            this.like = like;
        }

        public ModelVideo()
        {
        }
    }
}
