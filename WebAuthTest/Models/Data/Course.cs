using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAuthTest.Models.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(4)]
        //[DataType("nchar")]
        public string Prefix { get; set; }

        [Required]
        [MaxLength(4)]
        //[DataType("nchar")]
        public string Number { get; set; }

        // Navigation Property
        public List<Section> Sections { get; set; }
    }
}
