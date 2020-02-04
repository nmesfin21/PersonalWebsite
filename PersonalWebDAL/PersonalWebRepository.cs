using PersonalWebDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PersonalWebDAL
{
    public class PersonalWebRepository
    {
        PerWebDBContext context;

        public PersonalWebRepository(PerWebDBContext _context)
        {
            context = _context;
        }


        // get all projects
        public List<Projects> GetAllProjects()
        {
            var projectList = (from project in context.Projects
                               orderby project.DateCreated
                               select project).ToList();
                         
            return projectList;
        }

        //get all courses
        public List<Courses> GetAllCourses()
        {
            var courseList = (from c in context.Courses
                              select c).ToList();
            return courseList;
        }

        //get contact info
        public List<ContactInfo> GetContacts()
        {
            var contact = (from c in context.ContactInfo
                           select c).ToList();
            return contact;
        }

        //get about 
        public List<About> GetAbout()
        {
            var about = (from a in context.About
                         select a).ToList();
            return about;
        }

        //get resume
        public List<Resumes> GetResumes()
        {
            var res = (from r in context.Resumes
                         select r).ToList();
            return res;
        }
    }
}
