using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebWF.Pages
{
    public class EditBook : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        private readonly ILogger<EditBook> _logger;

        public EditBook(ILogger<EditBook> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost(){
            
        }
    }
}