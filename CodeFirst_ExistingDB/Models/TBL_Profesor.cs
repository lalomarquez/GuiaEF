namespace CodeFirst_ExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_Profesor
    {
        [Key]
        public int IdProfesor { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        public int DiaNacimiento { get; set; }

        public int MesNacimiento { get; set; }

        public int AnoNacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public string LugardeNacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public string Domicilio { get; set; }

        [Required]
        [StringLength(150)]
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefono { get; set; }
    }
}
