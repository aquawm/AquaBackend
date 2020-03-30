using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        
        [DataType(DataType.Date)]
        public DateTime TradeDate { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime SettleDate { get; set; }

        public float Quantity { get; set; }

        [DataType(DataType.Currency)]
        public float TradeAmount { get; set; }

        [DataType(DataType.Currency)]
        public float UnitPrice { get; set; }

        public String Comment { get; set; }

    }
}
