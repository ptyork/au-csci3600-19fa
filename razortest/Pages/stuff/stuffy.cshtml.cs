using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razortest.Pages.stuff
{
    public class stuffyModel : PageModel
    {
        public string PaulsFolly { get; set; }

        public void OnGet()
        {
            PaulsFolly = "Paul Wuz Here";
        }
    }
}




