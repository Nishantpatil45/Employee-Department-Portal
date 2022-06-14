using EmpDeptPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpDeptPortal.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
