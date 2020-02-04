using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebAPI.Models
{
    public class Resume
    {
        public int ResumeId { get; set; }
        public string ResumeType { get; set; }
        public byte[] ResumePdf { get; set; }
    }
}
