using System;
using System.Collections.Generic;

namespace PersonalWebDAL.Models
{
    public partial class ContactInfo
    {
        public int ContactId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedIn { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string TicTok { get; set; }
        public string Website { get; set; }
    }
}
