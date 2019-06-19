using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class AnnouncmentProperty : Entity<Guid>
    {
        public string Subject { get; set; }
        public string PrimaryCategory { get; set; }
        public string SecondaryCategory { get; set; }
        public string Message { get; set; }
        public string LanguageCode { get; set; }
    }
}
