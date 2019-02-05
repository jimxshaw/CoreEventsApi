using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Models
{
    public class TalkModel
    {
        public int TalkId { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public int Level { get; set; }

        public SpeakerModel speaker { get; set; }
    }
}