using Abp.AutoMapper;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(MyLanguage))]
    public class MyLanguageDto
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
    }
}