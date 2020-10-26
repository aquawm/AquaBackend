using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AquaBackend.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Portfolio")]
        public String PortfolioCode { get; set; }

        [DisplayName("Codigo")]
        public String TransactionCode { get; set; }

        [DisplayName("Type")]
        public String TranCodeLabel { get; set; }

        [DisplayName("Security Type")]
        public String SecTypeCode1 { get; set; }

        [DisplayName("Symbol")]
        public String Symbol1 { get; set; }

        [DisplayName("Security")]
        public String FullName1 { get; set; }

        public String PrincipalCurrencyCode1 { get; set; }

        [DisplayName("Source Security Type")]
        public String SecTypeCode2 { get; set; }

        [DisplayName("Source Type")]
        public String Symbol2 { get; set; }

        [DisplayName("Source Security")]
        public String FullName2 { get; set; }

        public String PrincipalCurrencyCode2 { get; set; }

        //[DataType(DataType.Date)]
        public String TradeDate { get; set; }

        //[DataType(DataType.Date)]
        public String SettleDate { get; set; }

        public String Quantity { get; set; }

        [DataType(DataType.Currency)]
        public String TradeAmount { get; set; }

        [DataType(DataType.Currency)]
        public String UnitPrice { get; set; }

        public String Comment { get; set; }

        public String PortfolioTransactionID { get; set; }
    }
}
