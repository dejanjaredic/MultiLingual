using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LanguageOmg.Authorization.Roles;
using LanguageOmg.Authorization.Users;
using LanguageOmg.Models;
using LanguageOmg.MultiTenancy;

namespace LanguageOmg.EntityFrameworkCore
{
    public class LanguageOmgDbContext : AbpZeroDbContext<Tenant, Role, User, LanguageOmgDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LanguageOmgDbContext(DbContextOptions<LanguageOmgDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
        public DbSet<MyLanguage> MyLanguages { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<DeviceUsage> DeviceUsage { get; set; }
        public DbSet<Announcment> Announcments { get; set; }
        public DbSet<AnnouncmentProperty> AnnouncmentPropertyes { get; set; }
    }
}
