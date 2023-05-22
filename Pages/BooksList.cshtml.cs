using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebWF.DB;
using WebWF.Models;

namespace WebWF.Pages
{
    public class BooksList : PageModel
    {
        private readonly ILogger<BooksList> _logger;
        private readonly WebDbContext _context;

        public BooksList(ILogger<BooksList> logger, WebDbContext context)
        {
            this._context = context;
            _logger = logger;
        }

        public List<Book> Books { get; set; }

        public void OnGet()
        {

            Books = _context.books.ToList();
        }
    }
}