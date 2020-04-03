using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AquaBackend.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public String Name { get; set; }

        [DisplayName("Portfolio")]
        public String Portfolio { get; set; }

        [DisplayName("Banco")]
        public String Bank { get; set; }

        [DisplayName("Cuenta")]
        public String Account { get; set; }

        [DisplayName("Titular")]
        public String Holder { get; set; }
    }
}
