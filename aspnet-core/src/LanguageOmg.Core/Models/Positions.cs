using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class Positions : Entity<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
