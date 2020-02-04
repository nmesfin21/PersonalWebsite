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
    public class AboutController : ControllerBase
    {
        private readonly PersonalWebRepository _repository;
        private readonly IMapper _mapper;

        // constructor
        public AboutController(PersonalWebRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/About
        [HttpGet]
        public JsonResult GetAbout()
        {
            List<Models.About> abouts = new List<Models.About>();
            try
            {
                List<About> aboutList = _repository.GetAbout();
                if(aboutList != null)
                {
                    foreach (var about in aboutList)
                    {
                        Models.About abtObj = _mapper.Map<Models.About>(about);
                        abouts.Add(abtObj);
                    }
                }
            }catch(Exception ex)
            {
                abouts = null;
            }
            return new JsonResult(abouts);
        }

        //// GET: api/About/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/About
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/About/5
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
