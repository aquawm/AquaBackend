using AquaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AquaBackend.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AquaBackendContext _context;

        public ReportsController(AquaBackendContext context)
        {
            _context = context;
        }
        public IActionResult PortfolioReports(String portfolio)
        {
            if (portfolio != null)
            {
                portfolio = portfolio.Replace(" ", "_");
            }

            if (System.IO.File.Exists(@"\\srv-app\apx$\Reportes\Portfolios\Portfolios.txt"))
            {
                IEnumerable<string> portfoliosList = System.IO.File.ReadLines(@"\\srv-app\apx$\Reportes\Portfolios\Portfolios.txt");
                ViewBag.portfolios = portfoliosList;
            }
            else
            {
                return RedirectToAction("Error", new { errorDescription = "No se encuentra el archivo Portafolios.txt, comuniquese con el area técnica para resolver este problema" });
            }

            List<Reports> PortfolioReports = new List<Reports>();

            if (portfolio == null)
            {
                return View(PortfolioReports);
            }
            else
            {
                var files = System.IO.Directory.GetFiles(@"\\srv-app\apx$\Reportes\Portfolios", String.Format("*{0}.pdf", portfolio), System.IO.SearchOption.AllDirectories);

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

                    Reports Report = new Reports
                    {
                        Portfolio = reportPortfolio.Replace("_", " "),
                        Report = report,
                        Url = file,
                        LastUpdate = lastUpdate
                    };
                    PortfolioReports.Add(Report);
                }
                return View(PortfolioReports);
            }
        }

        public IActionResult GeneralReports()
        {
            List<Reports> Reports = new List<Reports>();

            var files = System.IO.Directory.GetFiles(@"\\srv-app\apx$\Reportes\Generales\");

            foreach (var file in files)
            {
                string[] splitBarra = file.Split(@"\");
                string resultBarra = splitBarra.Last();

                string[] splitPunto = resultBarra.Split(".");
                string resultPunto = splitPunto.First();

                string[] splitGuion = resultPunto.Split("-");

                string report = splitGuion[0];
                string description = splitGuion[1];

                DateTime lastUpdate = System.IO.File.GetLastWriteTime(file);

                Reports Report = new Reports
                {
                    Description = description.Replace("_", " "),
                    Report = report.Replace("_", " "),
                    Url = file,
                    LastUpdate = lastUpdate
                };
                Reports.Add(Report);
            }
            return View(Reports);
        }

        public IActionResult ViewPortfolioReport(String portfolio, String report)
        {
            portfolio = portfolio.Replace(" ", "_");
            String path = @"\\srv-app\apx$\Reportes\Portfolios\";
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

        public IActionResult ViewGeneralReport(String description, String report)
        {
            report = report.Replace(" ", "_");
            description = description.Replace(" ", "_");
            String path = @"\\srv-app\apx$\Reportes\Generales\";
            String file = (String.Format("{0}-{1}.pdf", report,description));

            if (System.IO.File.Exists(String.Format("{0}{1}", path, file)))
            {
                return new PhysicalFileResult(String.Format("{0}{1}", path, file), "application/pdf");
            }
            else
            {
                return RedirectToAction("Error", new { errorDescription = "No se encuentra el reporte solicitado. " + String.Format("{0}{1}", path, file) });
            }
        }

        public IActionResult ViewPortfolioReportErrors(String portfolio, String report)
        {
            portfolio = portfolio.Replace(" ", "_");

            String path = @"\\srv-app\apx$\Reportes\Portfolios\";
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