using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Admin:Utilisateur
    {

        [Display(Name = "Rccm"), MaxLength(40, ErrorMessage = "La taille maximale est 40")]
        public string Rccm { get; set; }
    }
}