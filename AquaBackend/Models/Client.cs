using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;

namespace AquaBackend.Models
{
    public class Client
    {
        //[Key]
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

        [HiddenInput(DisplayValue = false)]
        public string CompleteName
        {
            get
            {
                return string.Format("{0} - {1}", Portfolio, Name);
            }
        }
    }
}
