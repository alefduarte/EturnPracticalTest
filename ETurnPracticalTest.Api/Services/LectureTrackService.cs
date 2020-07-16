using ETurnPracticalTest.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ETurnPracticalTest.Api.Services
{
    public class LectureTrackService : ILectureTrackService
    {
        protected static List<LectureTrack> LectureTrackList { get; }
        protected static List<Lecture> LectureList { get; }

        private readonly Track[] tracks = new Track[2]
        {
            new Track(1, "Trilha 1"),
            new Track(2, "Trilha 2")
        };

        private readonly ILectureService _lectureService;
        private readonly ITrackService _trackService;

        public LectureTrackService(ILectureService lectureService, ITrackService trackService)
        {
            _lectureService = lectureService;
            _trackService = trackService;
        }

        static LectureTrackService()
        {
            LectureTrackList = new List<LectureTrack>();

            LectureList = new List<Lecture>()
            {
                new Lecture(1, "Escrevendo testes rápidos", 60),
                new Lecture(2, "Uma visão sobre Python", 45),
                new Lecture(3, "Angular", 30),
                new Lecture(4, "Otimizando aplicações com o NodeJS", 45),
                new Lecture(5, "Erros comuns no desenvolvimento de software", 45),
                new Lecture(6, "Rails para Desenvolvedores Python", 60),
                new Lecture(7, "ASP.net MV", 60),
                new Lecture(8, "TDD na prática", 45),
                new Lecture(9, "Woah", 30),
                new Lecture(10, "Sente e escreva", 30),
                new Lecture(11, "Pair Programming vs Noise", 45),
                new Lecture(12, "Mobilidade em desenvolvimento", 60),
                new Lecture(13, "Ruby on Rails: Por que devemos migrar para ele?", 60),
                new Lecture(14, "Otimizando aplicações .NE", 45),
                new Lecture(15, "Java e os novos paradigmas de programação", 30),
                new Lecture(16, "Rubi vs. Clojure para Back-End", 30),
                new Lecture(17, "Scrum para leigo", 60),
                new Lecture(18, "Um mundo sem stackoverflow", 30),
                new Lecture(19, "UX", 30),
                new Lecture(20, "Evento de Networking"),
                new Lecture(21, "Evento de Networking"),
                new Lecture(22, "Almoço", 30),
                new Lecture(23, "Almoço", 30),
            };
        }

        public ServiceResponse<IEnumerable<LectureTrackResponse>> AllocateLectures()
        {
            _trackService.StoreTrack(tracks[0]);
            _trackService.StoreTrack(tracks[1]);

            LectureList.ForEach(record => _lectureService.StoreLecture(record));

            IEnumerable<Lecture> StoredLectures = _lectureService.GetLectures().Data;

            foreach (Lecture lecture in StoredLectures)
            {
                AddLecture(lecture);
            }

            return new ServiceResponse<IEnumerable<LectureTrackResponse>>()
            {
                Data = FormatResponse(LectureTrackList)
            };
        }

        public ServiceResponse<IEnumerable<LectureTrack>> GetLectureTracks()
        {
            return new ServiceResponse<IEnumerable<LectureTrack>>()
            {
                Data = LectureTrackList
            };
        }

        public void AddLecture(Lecture lecture)
        {
            int id = LectureTrackList.Select(record => record.Id).DefaultIfEmpty().Max() + 1;
            if (lecture.Id == 20)
            {
                AddToAfternoon(new LectureTrack(id, lecture, tracks[0], tracks[0].LastAfternoonLecture), tracks[0]);
            }
            else if (lecture.Id == 21)
            {
                AddToAfternoon(new LectureTrack(id, lecture, tracks[1], tracks[1].LastAfternoonLecture), tracks[1]);
            }
            else if (lecture.Id == 22)
            {
                AddToAfternoon(new LectureTrack(id, lecture, tracks[0], tracks[0].LastMorningLecture), tracks[0]);
            }
            else if (lecture.Id == 23)
            {
                AddToAfternoon(new LectureTrack(id, lecture, tracks[1], tracks[1].LastMorningLecture), tracks[1]);
            }
            else
            {
                foreach (Track track in tracks)
                {
                    TimeSpan nextMorningStartTime = track.LastMorningLecture + new TimeSpan(0, lecture.Duration, 0);
                    TimeSpan nextAfternoonStartTime = track.LastAfternoonLecture + new TimeSpan(0, lecture.Duration, 0);
                    if (nextMorningStartTime <= new TimeSpan(11, 30, 0) || nextMorningStartTime == new TimeSpan(12, 0, 0))
                    {
                        AddToMorning(new LectureTrack(id, lecture, track, track.LastMorningLecture), track);
                        break;
                    }
                    else if (nextAfternoonStartTime <= new TimeSpan(16, 30, 0) || nextAfternoonStartTime == new TimeSpan(17, 0, 0))
                    {
                        AddToAfternoon(new LectureTrack(id, lecture, track, track.LastAfternoonLecture), track);
                        break;
                    }
                }
            }
        }

        public static void AddToMorning(LectureTrack lectureTrack, Track track)
        {
            LectureTrackList.Add(lectureTrack);
            track.LastMorningLecture += new TimeSpan(0, lectureTrack.Lecture.Duration, 0);
        }

        public void AddToAfternoon(LectureTrack lectureTrack, Track track)
        {
            LectureTrackList.Add(lectureTrack);
            track.LastAfternoonLecture += new TimeSpan(0, lectureTrack.Lecture.Duration, 0);
        }


        public static IEnumerable<LectureTrackResponse> FormatResponse(List<LectureTrack> lectureTracks)
        {
            List<LectureTrackResponse> LectureTrackResponseList = new List<LectureTrackResponse>();
            lectureTracks.ForEach(record =>
            LectureTrackResponseList.Add(new LectureTrackResponse(record.StartTime.ToString(),
            record.Lecture.Title,
            $"{record.Lecture.Duration}m",
            record.Track.Title)
            ));

            return LectureTrackResponseList.OrderBy(record => record.Track).ThenBy(record => record.Time);
        }

        public ServiceResponse<LectureTrack> GetLectureTrack(int id)
        {
            LectureTrack lectureTrack = LectureTrackList.Where(record => record.Id == id).FirstOrDefault();
            return new ServiceResponse<LectureTrack>()
            {
                Data = lectureTrack
            };
        }
    }
}
