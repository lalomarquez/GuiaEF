namespace CodeFirst_ExistingDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProfesorDBContext : DbContext
    {
        public ProfesorDBContext()
            : base("name=ConnDB")
        {
        }

        public virtual DbSet<TBL_Profesor> Profesor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_Profesor>().MapToStoredProcedures(
                sp =>
                sp.Update(u => u.HasName("[dbo].[sp_UpdateProfesor]")
                    .Parameter(p => p.IdProfesor, "IdProfesor")
                    .Parameter(p => p.Nombre, "Nombre")
                    .Parameter(p => p.ApellidoPaterno, "ApellidoPaterno")
                    .Parameter(p => p.ApellidoMaterno, "ApellidoMaterno")
                    .Parameter(p => p.DiaNacimiento, "DiaNacimiento")
                    .Parameter(p => p.MesNacimiento, "MesNacimiento")
                    .Parameter(p => p.AnoNacimiento, "AnoNacimiento")
                    .Parameter(p => p.LugardeNacimiento, "LugardeNacimiento")
                    .Parameter(p => p.Domicilio, "Domicilio")
                    .Parameter(p => p.CorreoElectronico, "CorreoElectronico")
                    .Parameter(p => p.Telefono, "Telefono"))
                .Delete(d => d.HasName("[dbo].[sp_DeleteProfesor]")
                    .Parameter(p => p.IdProfesor, "IdProfesor"))
                .Insert(i => i.HasName("[dbo].[sp_InsertProfesor]")
                    .Parameter(p => p.Nombre, "Nombre")
                    .Parameter(p => p.ApellidoPaterno, "ApellidoPaterno")
                    .Parameter(p => p.ApellidoMaterno, "ApellidoMaterno")
                    .Parameter(p => p.DiaNacimiento, "DiaNacimiento")
                    .Parameter(p => p.MesNacimiento, "MesNacimiento")
                    .Parameter(p => p.AnoNacimiento, "AnoNacimiento")
                    .Parameter(p => p.LugardeNacimiento, "LugardeNacimiento")
                    .Parameter(p => p.Domicilio, "Domicilio")
                    .Parameter(p => p.CorreoElectronico, "CorreoElectronico")
                    .Parameter(p => p.Telefono, "Telefono"))
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
