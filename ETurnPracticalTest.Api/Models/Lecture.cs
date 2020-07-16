using System;

namespace ETurnPracticalTest.Api.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; } = 0;
        public Track Track { get; set; }

        public Lecture() { }

        public Lecture(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Lecture(int id, string title, int duration) : this(id, title)
        {
            Duration = duration;
        }

        public Lecture(int id, string title, int duration, Track track) : this(id, title, duration)
        {
            Track = track;
        }

        public void AttachTrack(Track track)
        {
            Track = track;
        }
    }
}
