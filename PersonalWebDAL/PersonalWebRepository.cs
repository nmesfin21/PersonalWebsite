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

        #region Project Region
        // get all projects
        public List<Projects> GetAllProjects()
        {
            var projectList = (from project in context.Projects
                               orderby project.DateCreated
                               select project).ToList();
                         
            return projectList;
        }
        #endregion
        
        
        #region Course Region
        //get all courses
        public List<Courses> GetAllCourses()
        {
            var courseList = (from c in context.Courses
                              select c).ToList();
            return courseList;
        }

        //add courses
        public string addCourse(string courseName, string courseDescription, string courseLink, string semester)
        {
            string status = "adding not successful";
            try
            {
                var course = new Courses();
                course.CourseName = courseName;
                course.CourseDescription = courseDescription;
                course.CourseLink = courseLink;
                course.Semester = semester;

                context.Courses.Add(course);
                context.SaveChanges();
                status = "adding course successful";
            }
            catch(Exception ex)
            {
                status = ex.Message;
            }
            return status;
        }
        #endregion


        #region contact region
        //get contact info
        public List<ContactInfo> GetContacts()
        {
            var contact = (from c in context.ContactInfo
                           select c).ToList();
            return contact;
        }
        #endregion

        #region about region
        //get about 
        public List<About> GetAbout()
        {
            var about = (from a in context.About
                         select a).ToList();
            return about;
        }
        #endregion

        #region resume
        //get resume
        public List<Resumes> GetResumes()
        {
            var res = (from r in context.Resumes
                         select r).ToList();
            return res;
        }
        #endregion
    }
}