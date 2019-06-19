using System;
using Abp.AutoMapper;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(Office))]
    public class OfficeDto
    {
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public Guid OfficeId { get; set; }
        //public Guid UuId { get; set; }
    }
}