using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(Experience))]
    public class ExperienceInputDto
    {
        public Guid EmployeeId { get; set; }
        public int LanguageId { get; set; }
        public string Note { get; set; }
        public string Position { get; set; }
        public string Organisation { get; set; }

    }
}
