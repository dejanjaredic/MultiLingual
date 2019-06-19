using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(Employee))]
    public class EmployeeCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int LanguageId { get; set; }

        //public int OfficeId { get; set; }
        public List<ExperienceDto> Experience { get; set; } = new List<ExperienceDto>();
    }
}
