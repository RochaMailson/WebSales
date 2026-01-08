using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesAgain.Data;
using WebSalesAgain.Models;

namespace WebSalesAgain.Services
{
    public class SellerService
    {
        private readonly WebSalesAgainContext _context;

        public SellerService(WebSalesAgainContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
