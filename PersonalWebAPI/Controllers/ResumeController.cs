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
    public class ResumeController : ControllerBase
    {
        private readonly PersonalWebRepository _repository;
        private readonly IMapper _mapper;

        // constructor
        public ResumeController(PersonalWebRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/Resume
        [HttpGet]
        public JsonResult GetAllResumes()
        {
            List<Models.Resume> resumes = new List<Models.Resume>();
            try
            {
                List<Resumes> resumeList = _repository.GetResumes();
                if(resumeList != null)
                {
                    foreach (var resume in resumeList)
                    {
                        Models.Resume resumeObj = _mapper.Map<Models.Resume>(resume);
                        resumes.Add(resumeObj);
                    }
                }
            }
            catch(Exception ex)
            {
                resumes = null;
            }
            return new JsonResult(resumes);
        }

        //// GET: api/Resume/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Resume
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Resume/5
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
