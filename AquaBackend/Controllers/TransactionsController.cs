using AquaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public IActionResult Transactions(String portfolio, DateTime dateFrom, DateTime dateTo)
        {
            ViewBag.portfolios = new SelectList(_context.Client.OrderBy(c => c.Portfolio), "Portfolio", "CompleteName");


            if (portfolio == null)
            {
                return View();
            }
            else
            {
                List<Transaction> transactions = new List<Transaction>();

                //var transaction = _context.Transaction.Where(t => t.PortfolioCode == portfolio && t.TradeDate >= dateFrom && t.TradeDate <= dateTo).OrderBy(t => t.TradeDate).ThenBy(t => t.PortfolioTransactionID);
                using (SqlConnection sqlConnection = new SqlConnection("data source=192.168.1.7;Database=APXFirm;User ID=lmachado;Password=Aq.Sql.2020"))
                {
                    using var cmd = new SqlCommand()
                    {
                        CommandText = String.Format(@"SELECT
                        vap.PortfolioCode,
                        pt.TransactionCode,
                        tc.TranCodeLabel,
                        pt.SecTypeCode1,
                        vs1.Symbol as Symbol1,
                        vs1.FullName as FullName1,
                        vs1.PrincipalCurrencyCode as PrincipalCurrencyCode1,
                        pt.SecTypeCode2,
                        vs2.Symbol as Symbol2,
                        vs2.FullName as FullName2,
                        vs2.PrincipalCurrencyCode as PrincipalCurrencyCode2,
                        convert(date,pt.TradeDate) as TradeDate,
                        convert(date,pt.SettleDate) as SettleDate,
                        pt.Quantity as Quantity,
                        pt.TradeAmount as TradeAmount,
                        ISNULL(pt.TradeAmount / pt.Quantity, '') as UnitPrice,
                        pt.Comment,
                        pt.PortfolioTransactionID
                        FROM
                            APXFirm.dbo.AdvPortfolioTransaction pt
                        left join APXFirm.dbo.vpAdvPortfolio vap on

                            pt.PortfolioID = vap.PortfolioID
                        left join APXFirm.dbo.AdvTransactionCode tc on

                            pt.TransactionCode = tc.TransactionCode
                        left join APXFirm.dbo.AdvSecurity vs1 on

                            pt.SecurityID1 = vs1.SecurityID
                        left join APXFirm.dbo.AdvSecurity vs2 on
                            pt.SecurityID2 = vs2.SecurityID
                        where
                            vap.PortfolioCode = '{0}' AND
                            pt.TradeDate >= '{1}' AND 
                            pt.TradeDate <= '{2}' 
                            order by pt.PortfolioTransactionID desc", portfolio, dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd")),
                        CommandType = CommandType.Text,
                        Connection = sqlConnection
                    };
                    sqlConnection.Open();

                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        String TradeDate;
                        String SettleDate;
                        Decimal TradeAmount;
                        Decimal Quantity;
                        if (reader[11].ToString().Equals("")) TradeDate = null; else TradeDate = Convert.ToDateTime(reader[11]).ToString("dd-MM-yyyy");
                        if (reader[12].ToString().Equals("")) SettleDate = null; else SettleDate = Convert.ToDateTime(reader[12]).ToString("dd-MM-yyyy");
                        if (reader[13].ToString().Equals("")) Quantity = -1; else Quantity = Convert.ToDecimal(reader[13]);
                        if (reader[14].ToString().Equals("")) TradeAmount = -1; else TradeAmount = Convert.ToDecimal(reader[14]);

                        Transaction transaction = new Transaction
                        {
                            PortfolioCode = reader[0].ToString(),
                            TransactionCode = reader[1].ToString(),
                            TranCodeLabel = reader[2].ToString(),
                            SecTypeCode1 = reader[3].ToString(),
                            Symbol1 = reader[4].ToString(),
                            FullName1 = reader[5].ToString(),
                            PrincipalCurrencyCode1 = reader[6].ToString(),
                            SecTypeCode2 = reader[7].ToString(),
                            Symbol2 = reader[8].ToString(),
                            FullName2 = reader[9].ToString(),
                            PrincipalCurrencyCode2 = reader[10].ToString(),
                            TradeDate = TradeDate,
                            SettleDate = SettleDate,
                            Quantity = Quantity.ToString("#,##0"),
                            TradeAmount = TradeAmount.ToString("#,##0"),
                            //UnitPrice = reader[15].ToString(),
                            Comment = reader[16].ToString(),
                            PortfolioTransactionID = reader[17].ToString()
                        };
                        transactions.Add(transaction);
                    }
                    sqlConnection.Close();
                }
                return View(transactions);
            }
        }
    }
}
