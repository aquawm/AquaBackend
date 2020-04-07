using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AquaBackend.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string SecTypeBaseCode { get; set; }
        public string PrincipalCurrencyCode { get; set; }
        public string Symbol { get; set; }

        [DisplayName("Name")]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Maturity Date")]
        public DateTime MaturityDate { get; set; }

        [DisplayName("Risk Country")]
        public string RiskCountryCode { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("As of")]
        public DateTime FromDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Good Through")]
        public DateTime ThruDate { get; set; }

        [DisplayName("Price")]
        public float PriceValue { get; set; }
    }
}
