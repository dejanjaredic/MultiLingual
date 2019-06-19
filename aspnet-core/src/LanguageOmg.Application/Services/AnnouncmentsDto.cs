using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageOmg.Services
{
    public class AnnouncmentsDto
    {
        public string Subject { get; set; }
        public string PrimaryCategory { get; set; }
        public string SecondaryCategory { get; set; }
        public string Message { get; set; }
        public int LanguageId { get; set; }
        //public Guid AnnouncmentId { get; set; }

    }
}
