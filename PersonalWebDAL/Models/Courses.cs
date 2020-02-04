using System;
using System.Collections.Generic;

namespace PersonalWebDAL.Models
{
    public partial class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseLink { get; set; }
        public string Semester { get; set; }
    }
}
