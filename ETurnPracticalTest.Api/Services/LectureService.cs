using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ETurnPracticalTest.Api.Services
{
    public class LectureService : ILectureService
    {
        protected static List<Lecture> LecturesList { get; }

        static LectureService()
        {
            LecturesList = new List<Lecture>();
        }

        public ServiceResponse<IEnumerable<Lecture>> GetLectures()
        {
            return new ServiceResponse<IEnumerable<Lecture>>()
            {
                Data = LecturesList
            };
        }

        public ServiceResponse<Lecture> GetLecture(int id)
        {
            var lecture = LecturesList.Where(record => record.Id == id).FirstOrDefault();
            return new ServiceResponse<Lecture>()
            {
                Data = lecture
            };
        }

        public ServiceResponse<Lecture> StoreLecture(Lecture lecture)
        {
            if (lecture == null)
                throw new Exception($"{nameof(lecture)} is null!");
            if (string.IsNullOrEmpty(lecture.Title))
                throw new Exception("Title is null!");
            if (lecture.Duration <= 0)
                throw new Exception("Invalid duraton!");

            lecture.Title = lecture.Title.Trim();

            var duplicateLecture = LecturesList.Any(record => record.Title == lecture.Title);
            if (duplicateLecture)
            {
                throw new Exception("Lecture has already been stored!");
            }

            var id = LecturesList.Select(record => record.Id).DefaultIfEmpty().Max() + 1;
            lecture.Id = id;

            LecturesList.Add(lecture);
            return new ServiceResponse<Lecture>()
            {
                Data = lecture
            };
        }

        public ServiceResponse<Lecture> UpdateLecture(int id, Lecture lecture)
        {
            if (lecture == null)
                throw new Exception($"{nameof(lecture)} is null.");
            if (id <= 0)
                throw new Exception("Invalid ID!");

            var storedLecture = LecturesList.Where(record => record.Id == id).FirstOrDefault();

            if (storedLecture == null)
                throw new Exception("Lecture not found!");

            storedLecture.Title = lecture.Title;
            storedLecture.Duration = lecture.Duration;

            return new ServiceResponse<Lecture>()
            {
                Data = storedLecture
            };

        }

        public void DeleteLecture(int id)
        {
            var storedLecture = LecturesList.Where(record => record.Id == id).FirstOrDefault();
            if (storedLecture == null)
                throw new Exception("Lecture not found!");

            LecturesList.Remove(storedLecture);
            return;
        }
    }
}
