using AutoMapper;
using PersonalWebDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Projects, Models.Project>();
            CreateMap<Courses, Models.Course>();
            CreateMap<PersonalWebDAL.Models.About, Models.About>();
            CreateMap<PersonalWebDAL.Models.ContactInfo, Models.Contact>();
            CreateMap<PersonalWebDAL.Models.Resumes, Models.Resume>();
        }
    }
}
