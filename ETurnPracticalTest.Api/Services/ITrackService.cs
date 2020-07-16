using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Services
{
    public interface ITrackService
    {
        Track GetTrack(int id);
        void StoreTrack(Track track);
        IEnumerable<Track> GetTracks();
    }
}
