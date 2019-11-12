using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAuthTest.Models.Data;

namespace WebAuthTest.Models.View
{
    public class HomeIndexVM
    {
        public List<Post> Comments { get; set; } = new List<Post>();
    }
}
