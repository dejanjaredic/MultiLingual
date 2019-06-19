using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LanguageOmg.Models
{
    public class Office : Entity
    {
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public Guid OfficeId { get; set; }
        //public Guid UuId { get; set; }

        //public List<Employee> Employee { get; set; } = new List<Employee>();
    }
}
