using EmpDeptPortal.Data;
using EmpDeptPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpDeptPortal.Controllers
{
    public class EmpDeptDetailsController : Controller  
    {
        private readonly ApplicationDbContext _context;

        public EmpDeptDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: EmpDeptDetailsController
        public ActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList();
            List<Department> department = _context.Department.ToList();

            var employeeRecord = from e in employees
                                 join d in department on e.DeptId equals d.DeptId into table1
                                 from d in table1.ToList()
                                 select new EmpDeptDetail
                                 {
                                     employee = e,
                                     department = d
                                 };

            return View(employeeRecord);
        }
    }
}
