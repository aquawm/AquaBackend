using System;
using System.ComponentModel.DataAnnotations;

namespace AquaBackend.Models
{
    public class ApxReports
    {
        [Key]
        public int Id { get; set; }
        public String Portfolio { get; set; }
        public String Report { get; set; }
        public String Url { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
