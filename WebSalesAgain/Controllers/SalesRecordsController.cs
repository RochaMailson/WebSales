using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesAgain.Services;

namespace WebSalesAgain.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesrecordservice;

        public SalesRecordsController(SalesRecordService salesrecordservice)
        {
            _salesrecordservice = salesrecordservice;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var result = await _salesrecordservice.FindByDateAsync(minDate, maxDate);
            return View();
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}
