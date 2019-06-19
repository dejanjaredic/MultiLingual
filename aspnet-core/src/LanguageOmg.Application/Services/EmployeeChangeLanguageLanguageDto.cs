using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LanguageOmg.Models;

namespace LanguageOmg.Services
{
    [AutoMap(typeof(MyLanguage))]
    public class EmployeeChangeLanguageLanguageDto : EntityDto<Guid>
    {
        public int LanguageId { get; set; }
    }
}
