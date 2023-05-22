using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebWF.Models;
using WebWF.Pages;

namespace WebWF.DB
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> books { get; set; }
    }
}