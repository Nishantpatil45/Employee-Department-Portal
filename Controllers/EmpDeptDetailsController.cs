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

        // GET: EmpDeptDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpDeptDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpDeptDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpDeptDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpDeptDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpDeptDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpDeptDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
