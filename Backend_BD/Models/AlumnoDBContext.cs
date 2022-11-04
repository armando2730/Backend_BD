using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Backend_BD.Models
{
    public class AlumnoDBContext : DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public AlumnoDBContext() : base(ConnectionString) { }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }

    }
    
}