using Microsoft.EntityFrameworkCore;
using StudentCrm.Domain.Entities;
using StudentCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {           
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendance>Attendances { get; set; }
        public DbSet<Expense>Expenses { get; set; }
        public DbSet<ExpenseType>ExpenseTypes { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Group>Groups { get; set; }
        public DbSet<InformationList>InformationLists { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Lesson>Lessons { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Position>Positions { get; set; }
        public DbSet<RegisterBlank>RegisterBlanks { get; set; }
        public DbSet<Role>Roles { get; set; }
        public DbSet<Satisfaction>Satisfactions { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<StudentPayment>StudentPayments { get; set; }
        public DbSet<StudentCrm.Domain.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        data.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        data.Entity.CreatedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChanges();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }



    }
}
