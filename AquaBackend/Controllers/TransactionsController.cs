using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace AquaBackend.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly AquaBackendContext _context;

        public TransactionsController(AquaBackendContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public IActionResult Transactions(String portfolio, Nullable<DateTime> dateFrom, Nullable<DateTime> dateTo)
        {
            ViewBag.portfolios = new SelectList(_context.Client.OrderBy(c => c.Name), "Portfolio", "CompleteName");

            if (dateFrom == null)
            {
                dateFrom = DateTime.Now.AddMonths(-1);
            }
            if (dateTo == null)
            {
                dateTo = DateTime.Today;
            }

            if (portfolio == null)
            {
                return View();
            }
            else
            {
                var transaction = _context.Transaction.Where(t => t.PortfolioCode == portfolio && t.TradeDate >= dateFrom && t.TradeDate <= dateTo).OrderBy(t => t.TradeDate).ThenBy(t => t.PortfolioTransactionID);
                return View(transaction);
            }
        }
    }
}
