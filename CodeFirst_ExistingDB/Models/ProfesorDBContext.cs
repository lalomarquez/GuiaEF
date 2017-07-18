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
        }
    }
}
