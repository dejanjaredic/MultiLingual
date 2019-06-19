using System;

namespace LanguageOmg.Services
{
    public class DeviceDto
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Guid DeviceId { get; set; }
        //public Guid UuId { get; set; }
    }
}