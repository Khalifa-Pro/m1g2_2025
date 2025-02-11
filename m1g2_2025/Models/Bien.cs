using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Bien
    {
        [Key]
        public int IdBien { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Libelle du bien"), MaxLength(160, ErrorMessage = "La taille maximale est 160")]
        public string LibelleBien { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Description"), MaxLength(160, ErrorMessage = "La taille maximale est 160")]
        public string DescriptionBien { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Prix journalier")]
        public float PrixJournalier { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Region du bien"), MaxLength(100, ErrorMessage = "La taille maximale est 100")]
        public string Region { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Pays du bien"), MaxLength(100, ErrorMessage = "La taille maximale est 100")]
        public string Pays { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Latitude du bien")]
        public float Latitude { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Longitude du bien")]
        public float Longitude { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Nombre de chambre")]
        public int NbreChambre { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Nombre du lit")]
        public int NbreLit { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Type de bien"), MaxLength(100, ErrorMessage ="La taille maximale est 100")]
        public string TypeBien { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
        public virtual ICollection<Annonce> Annonces { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}