using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvctest.Models.Data;
using mvctest.Models.View;

namespace mvctest.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            // NORMALLY; get this from a database
            var vm = new AttendanceIndexVM();
            //vm.Students = new List<Student>();
            var stud = new Student();
            stud.FirstName = "Paul";
            stud.LastName = "York";
            stud.DaysAttended = 10;
            vm.Students.Add(stud);

            stud = new Student() { FirstName = "Janice", LastName = "Deloach", DaysAttended = 0 };
            vm.Students.Add(stud);

            stud = new Student() { FirstName = "Michael", LastName = "Dowell", DaysAttended = -7, ImageName="dowell.jpg" };
            vm.Students.Add(stud);
            
            return View(vm);
        }
    }
}