using System.Data.Entity;

namespace CodeFirts.Models
{
    public class AlumnoDBContext : DbContext
    {
        public AlumnoDBContext() : base("ConnDB")
        { }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}