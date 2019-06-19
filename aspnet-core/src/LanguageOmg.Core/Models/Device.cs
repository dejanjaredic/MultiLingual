using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class Device : Entity<Guid>
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        //public int DeviceId { get; set; }
        public Guid DeviceId { get; set; }
        [ForeignKey("LanguageId")]
        public MyLanguage MyLanguage { get; set; }
    }
}
