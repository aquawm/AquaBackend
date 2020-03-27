using System;
using System.ComponentModel.DataAnnotations;

namespace AquaBackend.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }
        public String Url { get; set; }
        public bool Hidde { get; set; }
        public String Portfolio { get; set; }
    }
}
