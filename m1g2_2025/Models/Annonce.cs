using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Annonce
    {
        [Key]
        public int IdAnnonce { get; set; }

        [Required(ErrorMessage ="*"), Display(Name ="Date de debut")]
        public DateTime DateDebut { get; set; }

        [Required(ErrorMessage = "*"), Display(Name = "Date de fin")]
        public DateTime DateFin { get; set; }

        public string StatutAnnonce { get; set; }
        public int Bien_id { get; set; }
        [ForeignKey("Bien_id")]
        public virtual Bien Bien { get; set; }
    }
}