using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaBackend.Models
{
    [NotMapped]
    public class Reports
    {
        [Key]
        public int Id { get; set; }
        public String Portfolio { get; set; }
        public String Description { get; set; }
        public String Report { get; set; }
        public String Url { get; set; }
        public DateTime LastUpdate { get; set; }
        public String Custom1 { get; set; }
        public String Custom2 { get; set; }
        public String Custom3 { get; set; }
    }
}
