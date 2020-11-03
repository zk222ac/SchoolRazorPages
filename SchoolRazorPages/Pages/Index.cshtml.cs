using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SchoolRazorPages.Model;

namespace SchoolRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Student Student { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            Student = new Student();
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Message"] = "here is a new Page";
            //ViewData["student"] = new Student() {Id = 1,Name="alex",ImagePath="lion.jpg"};
            Student = new Student() {Id = 1,Name="alex",ImagePath="/Images/lion.jpg"};

        }
    }
}
