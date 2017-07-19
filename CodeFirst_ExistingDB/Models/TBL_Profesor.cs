namespace CodeFirst_ExistingDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web.Mvc;

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

        //public static IEnumerable<int> DaySelectList
        //{
        //    get
        //    {
        //        return Enumerable.Range(1, 31);
        //    }
        //}

        //public static IEnumerable<String> MonthSelectList
        //{
        //    get
        //    {
        //        return new System.Globalization.DateTimeFormatInfo().MonthNames;
        //    }
        //}

        //public static IEnumerable<int> YearSelectList
        //{
        //    get
        //    {
        //        return Enumerable.Range(DateTime.Now.Year - 30, 30 + 1);
        //    }
        //}

    }
}
