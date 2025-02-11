using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Nom et Prenom"), MaxLength(160, ErrorMessage = "La taille maximale est 160")]
        public string NomPrenom { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "*"), Display(Name = "Telephone"), MaxLength(20, ErrorMessage = "La taille maximale est 20")]
        public string Telephone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "*"), Display(Name = "Email"), MaxLength(80, ErrorMessage = "La taille maximale est 80")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Adresse"), MaxLength(20, ErrorMessage = "La taille maximale est 20")]
        public string Adresse { get; set; }
    }
}