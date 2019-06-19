using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using LanguageOmg.Users.Dto;

namespace LanguageOmg.Services
{
    public interface ITranslateService : IApplicationService
    {
        void CreateLanguage(MyLanguageDto input);
        void CreateOffice(OfficeDto input);
        void CreateExperience(ExperienceInputDto input);
        void CreateDevice(DeviceDto input);
        void CreateDeviceUsage(DeviceUsageDto input);
        List<OfficeDto> GetAllOffices(OfficeGetDto input, Guid id);
        void CreateEmployee(EmployeeCreateDto input);
        List<EmployeeDto> GetAllEmployee();
        void EditLanguageId(EmployeeChangeLanguageLanguageDto input);
        void CreateAnnoucment(AnnouncmentsInsertDto input);
    }
}
