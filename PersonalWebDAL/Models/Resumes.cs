using System;
using System.Collections.Generic;

namespace PersonalWebDAL.Models
{
    public partial class Resumes
    {
        public int ResumeId { get; set; }
        public string ResumeType { get; set; }
        public byte[] ResumePdf { get; set; }
    }
}
