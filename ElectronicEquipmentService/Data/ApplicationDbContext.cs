using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ElectronicEquipmentService.Data;

namespace ElectronicEquipmentService.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ElectronicEquipmentService.Data.Employee> Employee { get; set; }
        public DbSet<ElectronicEquipmentService.Data.Execute> Execute { get; set; }
        public DbSet<ElectronicEquipmentService.Data.Order> Order { get; set; }
    }
}
