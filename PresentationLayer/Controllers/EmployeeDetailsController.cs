using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Index()
        {
            var employee = new ClassBLL();
            List<Employee> employeeName = employee.namesDetail();
            return View(employeeName);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Save(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                return View("New");
            }
            else
            {
                var newEmployee = new ClassBLL();
                newEmployee.addEmployee(employee);
            }
            return RedirectToAction("Index", "EmployeeDetails");
        }
    }
}