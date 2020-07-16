using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Services
{
    public interface ILectureTrackService
    {
        ServiceResponse<IEnumerable<LectureTrackResponse>> AllocateLectures();
        ServiceResponse<IEnumerable<LectureTrack>> GetLectureTracks();
        void AddLecture(Lecture lecture);
        ServiceResponse<LectureTrack> GetLectureTrack(int id);
    }
}
