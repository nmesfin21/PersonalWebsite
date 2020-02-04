using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Languages { get; set; }
        public string Tools { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
