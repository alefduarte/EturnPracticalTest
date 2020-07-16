using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Services
{
    public class TrackService : ITrackService
    {
        protected static List<Track> TracksList { get; }

        static TrackService()
        {
            TracksList = new List<Track>();
        }

        public Track GetTrack(int id)
        {
            return TracksList.Where(record => record.Id == id).FirstOrDefault();
        }

        public void StoreTrack(Track track)
        {
            TracksList.Add(track);
        }

        public IEnumerable<Track> GetTracks()
        {
            return TracksList;
        }
    }
}
