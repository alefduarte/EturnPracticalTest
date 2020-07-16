using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Models
{
    public class LectureTrack
    {
        public Lecture Lecture { get; set; }
        public Track Track { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public LectureTrack(Lecture lecture, Track track, TimeSpan startTime, TimeSpan? endTime)
        {
            Lecture = lecture;
            Track = track;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
