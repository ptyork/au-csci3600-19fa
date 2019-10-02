using mvctest.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvctest.Models.View
{
    public class AttendanceIndexVM
    {
        public List<Student> Students { get; set; }// = new List<Student>();

        public AttendanceIndexVM()
        {
            this.Students = new List<Student>();
        }
    }
}
