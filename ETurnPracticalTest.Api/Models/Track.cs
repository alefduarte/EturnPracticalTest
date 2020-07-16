using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Track(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
