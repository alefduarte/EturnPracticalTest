using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Models
{
    public class LectureTrack
    {
        public int Id { get; set; }
        public Lecture Lecture { get; set; }
        public Track Track { get; set; }
        public TimeSpan StartTime { get; set; }

        public LectureTrack(int id, Lecture lecture, Track track, TimeSpan startTime)
        {
            Id = id;
            Lecture = lecture;
            Track = track;
            StartTime = startTime;
        }
    }
}
