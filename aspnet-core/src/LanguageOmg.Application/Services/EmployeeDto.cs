using System.Collections.Generic;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int LanguageId { get; set; }

        public List<ExperienceDto> Experience { get; set; } = new List<ExperienceDto>();
        public List<DeviceDto> DeviceUsage { get; set; } = new List<DeviceDto>();
    }
}