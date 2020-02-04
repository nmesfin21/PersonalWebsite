using System;
using System.Collections.Generic;

namespace PersonalWebDAL.Models
{
    public partial class Projects
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Languages { get; set; }
        public string Tools { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
