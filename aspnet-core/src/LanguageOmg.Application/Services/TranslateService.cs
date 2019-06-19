using System;
using System.Collections.Generic;
using System.Linq;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using LanguageOmg.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageOmg.Services
{
    public class TranslateService : LanguageOmgAppServiceBase, ITranslateService
    {
        private readonly IRepository<MyLanguage> _languageRepository;
        private readonly IRepository<Office> _officeRepository;
        private readonly IRepository<Employee, Guid> _employeeRepository;
        private readonly IRepository<Experience, Guid> _experienceRepository;
        private readonly IRepository<Device, Guid> _deviceRepository;
        private readonly IRepository<DeviceUsage> _deviceUsageRepository;
        private readonly IRepository<Announcment> _announcmentRepository;

        public TranslateService(
            IRepository<MyLanguage> languageRepository,
            IRepository<Office> officeRepository,
            IRepository<Employee, Guid> employeeRepository,
            IRepository<Experience, Guid> experienceRepository,
            IRepository<Device, Guid> deviceRepository,
            IRepository<DeviceUsage> deviceUsageRepository,
            IRepository<Announcment> announcmentRepository
            )
        {
            _languageRepository = languageRepository;
            _officeRepository = officeRepository;
            _employeeRepository = employeeRepository;
            _experienceRepository = experienceRepository;
            _deviceRepository = deviceRepository;
            _deviceUsageRepository = deviceUsageRepository;
            _announcmentRepository = announcmentRepository;
        }
        public void CreateLanguage(MyLanguageDto input)
        {
            var language = input.MapTo<MyLanguage>();
            _languageRepository.Insert(language);
        }

        public void CreateOffice(OfficeDto input)
        {
            var id = _officeRepository.InsertAndGetId(new Office());
            var office = _officeRepository.Get(id);
            office.LanguageId = input.LanguageId;
            office.Description = input.Description;
            if (input.OfficeId == Guid.Empty)
            {
                office.OfficeId = Guid.NewGuid();
            }
            else
            {
                office.OfficeId = input.OfficeId;
            }
        }

        public void CreateExperience(ExperienceInputDto input)
        {
            var exp = input.MapTo<Experience>();
            _experienceRepository.Insert(exp);
        }

        public void CreateDevice(DeviceDto input)
        {
            var device = new Device();
            device.LanguageId = input.LanguageId;
            device.Name = input.Name;
            if (input.DeviceId != Guid.Empty)
            {
                device.DeviceId = input.DeviceId;
                _deviceRepository.Insert(device);
            }
            else
            {
                device.DeviceId = _deviceRepository.InsertAndGetId(device);
            }
            _deviceRepository.Insert(device);
        }

        public void CreateDeviceUsage(DeviceUsageDto input)
        {
            var usage = new DeviceUsage();
            var getUsage = _deviceUsageRepository.GetAll().Where(x => x.Deviceid == input.DeviceId && x.EndDate == null);
            usage.Deviceid = input.DeviceId;
            usage.StartDate = DateTime.Now;
            usage.EmployeeId = input.EmployeeId;
            if (getUsage.Any())
            {
                getUsage.First().EndDate = DateTime.Now;
            }
            _deviceUsageRepository.Insert(usage);
        }

       

        public List<OfficeDto> GetAllOffices(OfficeGetDto input, Guid id)
        {
            var employee = _employeeRepository.Get(id);
            var offices = _officeRepository
                .GetAll().Where(x => x.Description.Contains(input.Description) && x.LanguageId == employee.LanguageId);
            var list = new List<Office>();
            foreach (var off in offices)
            {
                var office = new Office();
                office.OfficeId = off.OfficeId;
                office.Description = off.Description;
                office.LanguageId = off.LanguageId;
                list.Add(office);
            }
            return list.MapTo<List<OfficeDto>>();
        }

        public void CreateEmployee(EmployeeCreateDto input)
        {
            var testId = Guid.NewGuid();
            var employee = new Employee();
            employee.Id = testId;
            employee.FirstName = input.FirstName;
            employee.LastName = input.LastName;
            employee.Email = input.Email;
            employee.LanguageId = input.LanguageId;
            foreach (var exp in input.Experience)
            { 
                var experience = new Experience();
                experience.Id = Guid.NewGuid();
                experience.EmployeeId = testId;
                experience.LanguageId = input.LanguageId;
                experience.Position = exp.Position;
                experience.Organisation = exp.Organisation;
                experience.Note = exp.Note;
                employee.Experience.Add(experience);
            }
            _employeeRepository.Insert(employee);
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            var employees = _employeeRepository.GetAll().Include(x => x.Experience).ToList();
            var list = new List<Employee>();
            foreach (var emp in employees)
            {
                var employee = new Employee();
                employee.FirstName = emp.FirstName;
                employee.LastName = emp.LastName;
                employee.Email = emp.Email;
                employee.LanguageId = emp.LanguageId;
                foreach (var exp in emp.Experience)
                {
                    var experience = new Experience();
                    experience.Note = exp.Note;
                    employee.Experience.Add(experience);
                }
                foreach (var device in employee.DeviceUsage)
                {
                    var deviceUsage = new DeviceUsage();
                    deviceUsage.StartDate = device.StartDate;
                    deviceUsage.EndDate = device.EndDate;
                    deviceUsage.Deviceid = device.Deviceid;
                    employee.DeviceUsage.Add(deviceUsage);
                }
                list.Add(employee);
            }
            return list.MapTo<List<EmployeeDto>>();
        }

        public void EditLanguageId(EmployeeChangeLanguageLanguageDto input)
            {
            var employee = _employeeRepository.Get(input.Id);
                employee.LanguageId = input.LanguageId;
            _employeeRepository.Update(employee);
        }

        public void CreateAnnoucment(AnnouncmentsInsertDto input)
        {
            var list = new List<Announcment>();
            var announcmentId = Guid.NewGuid();
            foreach (var annoucment in input.Announcments)
            {
                var ann = new Announcment();
                //ann.Id = Guid.NewGuid();
                ann.Subject = annoucment.Subject;
                ann.PrimaryCategory = annoucment.PrimaryCategory;
                ann.SecondaryCategory = annoucment.SecondaryCategory;
                ann.Message = annoucment.Message;
                ann.LanguageId = annoucment.LanguageId;
                ann.AnnouncmentId = announcmentId;
                list.Add(ann);
            }
            var announcmentList = list.MapTo<List<Announcment>>();
            foreach (var announcment in announcmentList)
            {
                _announcmentRepository.Insert(announcment);
            }
        }

        public EmployeeDto GetByNameSurname(string name, string surname)
        {
            var emp = _employeeRepository.GetAll().First(x => x.FirstName.Equals(name) && x.LastName.Equals(surname));
            var details = _experienceRepository.GetAll().Where(x => x.LanguageId == emp.LanguageId && x.EmployeeId == emp.Id).OrderByDescending(x => x.Id);
            var devices = _deviceUsageRepository.GetAll()
                .Where(x => x.EmployeeId == emp.Id && x.EndDate == null);
            var employee = new EmployeeDto();
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.Email = emp.Email;
            employee.LanguageId = emp.LanguageId;
            foreach (var exp in details)
            {
                var experience = new ExperienceDto();
                experience.Position = exp.Position;
                experience.Organisation = exp.Organisation;
                experience.Note = exp.Note;
                //experience.LanguageId = exp.LanguageId;
                employee.Experience.Add(experience);
            }
            foreach (var device in devices)
            {
                var deviceName = _deviceRepository.GetAll().Where(x => x.LanguageId == emp.LanguageId && x.DeviceId == device.Deviceid);
                foreach (var dev in deviceName)
                {
                    var used = new DeviceDto();
                    used.Name = dev.Name;
                    employee.DeviceUsage.Add(used);
                }
            }
            return employee.MapTo<EmployeeDto>();
        }
    }
}
