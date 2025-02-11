using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Gestionnaire:Utilisateur
    {
        [Display(Name = "Ninea"), MaxLength(20, ErrorMessage = "La taille maximale est 20")]
        public string Ninea { get; set; }
    }
}