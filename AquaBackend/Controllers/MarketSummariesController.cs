using AquaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Collections.Generic;

namespace AquaBackend.Controllers
{
    public class MarketSummariesController : Controller
    {
        // GET: ViewMarketSummaries
        public ActionResult ViewMarketSummaries()
        {
            var client = new RestClient("https://apidojo-yahoo-finance-v1.p.rapidapi.com/market/get-summary?region=US&lang=en");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "76f8f07e34msh795619d21415bd8p1dd1bbjsnc85c615758c2");
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                MarketSummaryResponse marketsummary = Newtonsoft.Json.JsonConvert.DeserializeObject<MarketSummaryResponse>(response.Content);

                Result[] result = marketsummary.marketSummaryResponse.result;

                List<MarketSummary> summaries = new List<MarketSummary>();

                foreach (var item in result)
                {
                    MarketSummary summary = new MarketSummary
                    {
                        ShortName = item.shortName,
                        RegularMarketPrice = item.regularMarketPrice.fmt,
                        RegularMarketChangePercent = item.regularMarketChangePercent.fmt,
                        RegularMarketChange = item.regularMarketChange.fmt,
                        RegularMarketPreviousClose = item.regularMarketPreviousClose.fmt,
                        RegularMarketTime = item.regularMarketTime.fmt,
                        ExchangeTimezoneName = item.exchangeTimezoneName
                    };
                    summaries.Add(summary);
                }
                return View(summaries);
            }
            else
            {
                return View();
            }
        }
    }
}