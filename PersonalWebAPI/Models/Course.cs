using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseLink { get; set; }
        public string Semester { get; set; }
    }
}
