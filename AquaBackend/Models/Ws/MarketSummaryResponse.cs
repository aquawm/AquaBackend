using System.ComponentModel.DataAnnotations.Schema;

namespace AquaBackend.Models
{
    [NotMapped]
    public class MarketSummaryResponse
    {
        public Marketsummaryresponse marketSummaryResponse { get; set; }
    }

    public class Marketsummaryresponse
    {
        public Result[] result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public string fullExchangeName { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string symbol { get; set; }
        public Regularmarketchange regularMarketChange { get; set; }
        public int gmtOffSetMilliseconds { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public string language { get; set; }
        public Regularmarkettime regularMarketTime { get; set; }
        public Regularmarketchangepercent regularMarketChangePercent { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public string quoteType { get; set; }
        public Regularmarketprice regularMarketPrice { get; set; }
        public string marketState { get; set; }
        public string market { get; set; }
        public string quoteSourceName { get; set; }
        public int priceHint { get; set; }
        public bool tradeable { get; set; }
        public int sourceInterval { get; set; }
        public string exchange { get; set; }
        public string shortName { get; set; }
        public string region { get; set; }
        public Regularmarketpreviousclose regularMarketPreviousClose { get; set; }
        public bool triggerable { get; set; }
        public string headSymbolAsString { get; set; }
        public string currency { get; set; }
        public string longName { get; set; }
    }

    public class Regularmarketchange
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarkettime
    {
        public int raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketchangepercent
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketprice
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

    public class Regularmarketpreviousclose
    {
        public float raw { get; set; }
        public string fmt { get; set; }
    }

}