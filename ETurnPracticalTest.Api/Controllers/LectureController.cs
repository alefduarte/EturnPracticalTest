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
    [ApiController]
    [Route("api/[controller]")]
    public class LectureController : ControllerBase
    {

        private readonly ILectureService _repository;

        public LectureController(ILectureService repository)
        {
            _repository = repository;
        }

        // GET: api/Lecture
        [HttpGet]
        public ActionResult<IEnumerable<Lecture>> Get()
        {
            var lectures = _repository.GetLectures();

            return Ok(lectures);
        }

        // GET: api/Lecture/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Lecture> Get(int id)
        {
            var lecture = _repository.GetLecture(id);
            return Ok(lecture);
        }

        // POST: api/Lecture
        [HttpPost]
        public ActionResult<Lecture> Post(
            [FromBody] Lecture lecture
            )
        {
            try
            {
                var savedLecture = _repository.StoreLecture(lecture);
                return Ok(savedLecture);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT: api/Lecture/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Lecture lecture)
        {
            try
            {
                _repository.UpdateLecture(id, lecture);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _repository.DeleteLecture(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
