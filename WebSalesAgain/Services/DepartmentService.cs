using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesAgain.Data;
using WebSalesAgain.Models;
using Microsoft.EntityFrameworkCore;

namespace WebSalesAgain.Services
{
    public class DepartmentService
    {
        private readonly WebSalesAgainContext _context;

        public DepartmentService(WebSalesAgainContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }



    }
}
