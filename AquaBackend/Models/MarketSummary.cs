using System.ComponentModel.DataAnnotations.Schema;

namespace AquaBackend.Models
{
    [NotMapped]
    public class MarketSummary
    {
        public string ShortName { get; set; }
        public string RegularMarketPrice { get; set; }
        public string RegularMarketChangePercent { get; set; }
        public string RegularMarketChange { get; set; }
        public string RegularMarketPreviousClose { get; set; }
        public string RegularMarketTime { get; set; }
        public string ExchangeTimezoneName { get; set; }
    }
}
