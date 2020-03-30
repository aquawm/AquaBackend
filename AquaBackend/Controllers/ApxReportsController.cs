using AquaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaBackend.Controllers
{
    public class ApxReportsController : Controller
    {
        private readonly AquaBackendContext _context;

        public ApxReportsController(AquaBackendContext context)
        {
            _context = context;
        }
        public IActionResult ApxReports(String portfolio)
        {
            if (portfolio != null)
            {
                portfolio = portfolio.Replace(" ", "_");
            }

            if (System.IO.File.Exists(@"\\srv-app\apx$\Reportes\Portfolios.txt"))
            {
                IEnumerable<string> portfoliosList = System.IO.File.ReadLines(@"\\srv-app\apx$\Reportes\Portfolios.txt");
                ViewBag.portfolios = portfoliosList;
            }
            else
            {
                return RedirectToAction("Error", new { errorDescription = "No se encuentra el archivo Portafolios.txt, comuniquese con el area tecnica para resolver este problema" });
            }

            List<ApxReports> ApxReports = new List<ApxReports>();

            if (portfolio == null)
            {
                return View(ApxReports);
            }
            else
            {
                var files = System.IO.Directory.GetFiles(@"\\srv-app\apx$\Reportes\", String.Format("*{0}.pdf", portfolio), System.IO.SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    string[] splitBarra = file.Split(@"\");
                    string resultBarra = splitBarra.Last();

                    string[] splitPunto = resultBarra.Split(".");
                    string resultPunto = splitPunto.First();

                    string[] splitGuion = resultPunto.Split("-");

                    string report = splitGuion[0];
                    string reportPortfolio = splitGuion[1];

                    DateTime lastUpdate = System.IO.File.GetLastWriteTime(file);

                    ApxReports apxReport = new ApxReports
                    {
                        Portfolio = reportPortfolio.Replace("_", " "),
                        Report = report,
                        Url = file,
                        LastUpdate = lastUpdate
                    };
                    ApxReports.Add(apxReport);
                }
                return View(ApxReports);
            }
        }
        public IActionResult ViewReport(String portfolio, String report)
        {
            portfolio = portfolio.Replace(" ", "_");
            String path = @"\\srv-app\apx$\Reportes\";
            String file = (String.Format("{0}-{1}.pdf", report, portfolio));

            if (System.IO.File.Exists(String.Format("{0}{1}", path, file)))
            {
                return new PhysicalFileResult(String.Format("{0}{1}", path, file), "application/pdf");
            }
            else
            {
                return RedirectToAction("Error", new { errorDescription = "No se encuentra el reporte solicitado. " + String.Format("{0}{1}", path, file) });
            }
        }

        public IActionResult ViewErrors(String portfolio, String report)
        {
            portfolio = portfolio.Replace(" ", "_");

            String path = @"\\srv-app\apx$\Reportes\";
            String file = (String.Format("{0}-{1}.err", report, portfolio));

            if (System.IO.File.Exists(String.Format(@"{0}{1}", path, file)))
            {
                IEnumerable<string> errorList = System.IO.File.ReadLines((String.Format(@"{0}{1}", path, file)));

                ViewBag.errorList = errorList;
                return View();
            }
            else
            {
                return RedirectToAction("Error", new { errorDescription = "No se encuentra el archivo de errores del reporte." });
            }
        }

        public IActionResult Error(String errorDescription)
        {
            ViewBag.ErrorDescription = errorDescription;
            return View();
        }
    }
}