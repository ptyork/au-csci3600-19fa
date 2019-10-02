using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvctest.Models.Data
{
    // Just a POCO
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DaysAttended { get; set; }
        public string ImageName { get; set; } = "stu.jpg";
    }
}
