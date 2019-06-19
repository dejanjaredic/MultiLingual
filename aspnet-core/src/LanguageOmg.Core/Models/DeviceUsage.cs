using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class DeviceUsage : Entity
    {
        public Guid EmployeeId { get; set; }
        public Guid Deviceid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
    }
}
