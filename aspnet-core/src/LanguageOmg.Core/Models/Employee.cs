using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class Employee : Entity<Guid>
    {
        public Guid Uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int LanguageId { get; set; }
        //public int OfficeId { get; set; }
        public List<Experience> Experience { get; set; } = new List<Experience>();
        public List<DeviceUsage> DeviceUsage { get; set; } = new List<DeviceUsage>();

    }
}
