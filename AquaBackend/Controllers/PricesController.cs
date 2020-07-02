using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AquaBackend.Controllers
{
    public class PricesController : Controller
    {
        private readonly AquaBackendContext _context;

        public PricesController(AquaBackendContext context)
        {
            _context = context;
        }

        // GET: Prices
        public async Task<IActionResult> Prices(string searchString, Nullable<DateTime> dateFrom, Nullable<DateTime> dateTo)
        {
            if (dateFrom == null)
            {
                if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Monday))
                {
                    dateFrom = DateTime.Today.AddDays(-3);
                }
                else
                {
                    dateFrom = DateTime.Today.AddDays(-1);
                }
            }

            if (dateTo == null)
            {
                dateTo = DateTime.Today;
            }

            if (searchString == null)
            {
                return View(await _context.Price.Where(p => p.FromDate >= dateFrom && p.FromDate <= dateTo).OrderBy(p => p.Symbol).ThenBy(p => p.FromDate).ToListAsync());
            }
            else
            {
                ViewBag.searchString = searchString;
                ViewBag.dateFrom = dateFrom;
                ViewBag.dateTo = dateTo;
                return View(await _context.Price.Where(p => p.FromDate >= dateFrom && p.FromDate <= dateTo && (p.Symbol.Contains(searchString) || p.FullName.Contains(searchString))).OrderBy(p => p.Symbol).ThenBy(p => p.FromDate).ToListAsync());
            }
        }
    }
}
