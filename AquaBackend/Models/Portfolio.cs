using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaBackend.Models
{
    [NotMapped]
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ApxName { get; set; }
        public String Description { get; set; }
        [Required]
        public bool Active { get; set; }

    }
}
