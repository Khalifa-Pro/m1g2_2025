using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace m1g2_2025.Models
{
    public class m1gl2Context: DbContext
    {
        public m1gl2Context() : base("m1gl2Connection")
        {
        }

        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Gestionnaire> gestionnaires { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Bien> biens { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Annonce> annonces { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}