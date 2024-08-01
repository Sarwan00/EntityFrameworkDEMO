using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers

{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int id)
        {
            EmployeeContext context = new EmployeeContext();
            Employee employee = context.Employees.Single(emp => emp.id == id);
            return View(employee);
        }

        public ActionResult EmployeeNameList(int deptid)
        {
            EmployeeContext context = new EmployeeContext();
            List<Employee> employees = context.Employees.Where(emp => emp.deptid == deptid).ToList();
            return View(employees);
        }
    }
   
}