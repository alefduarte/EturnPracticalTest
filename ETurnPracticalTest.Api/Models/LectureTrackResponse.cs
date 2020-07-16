using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Models
{
    public class LectureTrackResponse
    {
        public String Time { get; set; }
        public String Title { get; set; }
        public String Duration { get; set; }
        public String Track { get; set; }

        public LectureTrackResponse(string time, string title, string duration)
        {
            Time = time;
            Title = title;
            Duration = duration;
        }

        public LectureTrackResponse(string time, string title, string duration, string track) : this(time, title, duration)
        {
            Track = track;
        }
    }
}
