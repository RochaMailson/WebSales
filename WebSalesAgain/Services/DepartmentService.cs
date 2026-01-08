using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesAgain.Data;
using WebSalesAgain.Models;

namespace WebSalesAgain.Services
{
    public class DepartmentService
    {
        private readonly WebSalesAgainContext _context;

        public DepartmentService(WebSalesAgainContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
