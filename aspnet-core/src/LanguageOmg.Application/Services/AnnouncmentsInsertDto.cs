using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(Annotatable))]
    public class AnnouncmentsInsertDto
    {
        //public string LanguageCode { get; set; }
        public List<AnnouncmentsDto> Announcments { get; set; } = new List<AnnouncmentsDto>();
    }
}
