using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark",
                    Email = "mark@work.com",
                    Department = Dept.IT
                },
                new Employee
                {
                    Id = 2,
                    Name = "Prince",
                    Email = "prince@work.com",
                    Department = Dept.HR
                }
                );
        }
    }
}
