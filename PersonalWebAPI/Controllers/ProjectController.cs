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
    public class ProjectController : ControllerBase
    {
        private readonly PersonalWebRepository _repository;
        private readonly IMapper _mapper;

        // constructor
        public ProjectController(PersonalWebRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/Project
        [HttpGet]
        public JsonResult GetProjects()
        {
            List<Models.Project> projects = new List<Models.Project>();
            try
            {
                List<Projects> projectList = _repository.GetAllProjects();
                if(projectList != null)
                {
                    foreach (var project in projectList)
                    {
                        Models.Project projectObj = _mapper.Map<Models.Project>(project);
                        projects.Add(projectObj);
                    }
                }
            }
            catch
            {
                projects = null;
            }
            return new JsonResult(projects);

        }

        //// GET: api/Project/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Project
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Project/5
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
