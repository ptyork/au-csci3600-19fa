using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuthTest.Models.Data
{
    public class Section
    {
        public int SectionId { get; set; }

        // Navigation Property
        public Course Course { get; set; }

        public int Year { get; set; }

        [Required]
        [MaxLength(3)]
        public String Semester { get; set; }

        [MaxLength(50)]
        public String Classroom { get; set; }

        public int? Size { get; set; }
    }
}
