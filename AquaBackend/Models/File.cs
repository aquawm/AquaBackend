using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaBackend.Models
{
    [NotMapped]
    public class File
    {
        [Key]
        public int Id { get; set; }
        public String Url { get; set; }
        public bool Hidde { get; set; }
        public String Portfolio { get; set; }
    }
}
