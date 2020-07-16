using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETurnPracticalTest.Api.Services
{
    public interface ILectureService
    {
        ServiceResponse<IEnumerable<Lecture>> GetLectures();
        ServiceResponse<Lecture> GetLecture(int id);
        ServiceResponse<Lecture> StoreLecture(Lecture lecture);
        ServiceResponse<Lecture> UpdateLecture(int id, Lecture lecture);
        void DeleteLecture(int id);

    }
}
