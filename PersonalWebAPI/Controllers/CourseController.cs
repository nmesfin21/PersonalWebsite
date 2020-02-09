using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebDAL;
using PersonalWebDAL.Models;

namespace PersonalWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly PersonalWebRepository _repository;
        private readonly IMapper _mapper;

        // constructor
        public CourseController(PersonalWebRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region course
        // GET: api/Course
        [HttpGet]
        public JsonResult GetAllCourses()
        {
            List<Models.Course> courses = new List<Models.Course>();
            try
            {
                List<Courses> courseList = _repository.GetAllCourses();
                if(courseList != null)
                {
                    foreach (var course in courseList)
                    {
                        Models.Course courseObj = _mapper.Map<Models.Course>(course);
                        courses.Add(courseObj);
                    }
                }
            }catch(Exception ex)
            {
                courses = null;
            }
            return new JsonResult(courses);
        }

        //POST: api/Course
        public JsonResult AddCourse(Models.Course course)
        {
            string status = "adding course failed in controller";
            try
            {
                status = _repository.addCourse(course.CourseName, course.CourseDescription, course.CourseLink, course.Semester);
            }
            catch(Exception ex)
            {
                status = ex.Message;
            }
            return new JsonResult(status);
        }
        #endregion

        //// GET: api/Course/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Course/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
