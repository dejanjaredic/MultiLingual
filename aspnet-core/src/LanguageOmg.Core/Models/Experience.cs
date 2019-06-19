using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class Experience : Entity<Guid>
    {
        public Guid EmployeeId { get; set; }
        public int LanguageId { get; set; }
        public string Position { get; set; }
        public string Organisation { get; set; }
        public string Note { get; set; }
        [ForeignKey("LanguageId")]
        public MyLanguage MyLanguage { get; set; }
    }
}