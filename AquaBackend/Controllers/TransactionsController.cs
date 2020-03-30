using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            var portfolios = _context.Transaction.Where(p => p.PortfolioCode != null).OrderBy(p => p.PortfolioCode).Select(p => p.PortfolioCode).Distinct();
            ViewBag.portfolios = portfolios;



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
