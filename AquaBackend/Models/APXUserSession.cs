using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace AquaBackend.Models
{
    [NotMapped]
    public class APXUserSession
    {
        public String SessionID { get; set; }
        [DisplayName("Nombre")]
        public String FullName { get; set; }
        [DisplayName("Inicio de sesión")]
        public String Created { get; set; }
        [DisplayName("Ultima Interacción")]
        public String LastTouched { get; set; }
    }
}
