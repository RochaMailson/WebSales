using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSalesAgain.Models;

namespace WebSalesAgain.Data
{
    public class WebSalesAgainContext : DbContext
    {
        public WebSalesAgainContext (DbContextOptions<WebSalesAgainContext> options)
            : base(options)
        {
        }

        public DbSet<WebSalesAgain.Models.Department> Department { get; set; }
    }
}
