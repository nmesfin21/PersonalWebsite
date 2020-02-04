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
    public class ContactController : ControllerBase
    {
        private readonly PersonalWebRepository _repository;
        private readonly IMapper _mapper;

        public ContactController(PersonalWebRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/Contact
        [HttpGet]
        public JsonResult GetAllContacts()
        {
            List<Models.Contact> contacts = new List<Models.Contact>();
            try
            {
                List<ContactInfo> contactInfos = _repository.GetContacts();
                if(contactInfos != null)
                {
                    foreach (var contact in contactInfos)
                    {
                        Models.Contact contactObj = _mapper.Map<Models.Contact>(contact);
                        contacts.Add(contactObj);
                    }
                }
            }
            catch(Exception ex)
            {
                contacts = null;
            }
            return new JsonResult(contacts);
        }

        //// GET: api/Contact/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Contact
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Contact/5
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
