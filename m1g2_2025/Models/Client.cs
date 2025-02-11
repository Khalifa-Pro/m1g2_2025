using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace m1g2_2025.Models
{
    public class Client: Utilisateur
    {
        [Display(Name = "CNI"), MaxLength(20, ErrorMessage = "La taille maximale est 20")]
        public string CNI { get; set; }

        [Display(Name = "Passport"), MaxLength(20, ErrorMessage = "La taille maximale est 20")]
        public string Passport { get; set; }


    }
}