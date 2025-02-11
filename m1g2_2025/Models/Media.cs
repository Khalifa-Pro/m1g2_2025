using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace m1g2_2025.Models
{
    public class Media
    {
        [Key]
        public int IdMedia { get; set; }
        public string TypeMedia { get; set; }
        public string Extension { get; set; }
        public string Url { get; set; }
        public string StatutMedia { get; set; }
        public int Bien_id { get; set; }
        [ForeignKey("Bien_id")]
        public virtual Bien Bien { get; set; }

    }
}