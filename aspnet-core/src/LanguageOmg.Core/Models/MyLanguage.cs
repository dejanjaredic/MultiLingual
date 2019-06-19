using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace LanguageOmg.Models
{
    public class MyLanguage : Entity
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
    }
}
