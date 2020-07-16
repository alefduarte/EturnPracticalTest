using System;

namespace ETurnPracticalTest.Api.Models
{
    public class Lecture
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public int Duration { get; set; } = 0;

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
    }
}
