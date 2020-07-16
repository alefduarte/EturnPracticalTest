using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETurnPracticalTest.Api.Models;
using ETurnPracticalTest.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETurnPracticalTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureTrackController : ControllerBase
    {
        private readonly ILectureTrackService _repository;

        public LectureTrackController(ILectureTrackService repository)
        {
            _repository = repository;
        }

        // GET: api/LectureTrack
        [HttpGet]
        public ActionResult<IEnumerable<LectureTrack>> Get()
        {
            var lectures = _repository.GetLectureTracks();

            return Ok(lectures);
        }

        // GET: api/LectureTrack/5
        [HttpGet("{id}")]
        public ActionResult<LectureTrack> Get(int id)
        {
            var lecture = _repository.GetLectureTrack(id);
            return Ok(lecture);
        }

        // GET: api/LectureTrack/Allocate
        [HttpGet("allocate")]
        public ActionResult<IEnumerable<LectureTrack>> Allocate()
        {
            var lectures = _repository.AllocateLectures();

            return Ok(lectures);
        }
    }
}
