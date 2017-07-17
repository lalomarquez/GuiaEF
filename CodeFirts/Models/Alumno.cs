using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirts.Models
{
    [Table("TBL_Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [DisplayName("Apellido Paterno")]
        [Required]
        [MaxLength(50)]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [Required]
        [MaxLength(50)]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Día")]
        [Required]
        public int DiaNacimiento { get; set; }

        [DisplayName("Mes")]
        [Required]
        public int MesNacimiento { get; set; }

        [DisplayName("Año")]
        [Required]
        public int AnoNacimiento { get; set; }

        [DisplayName("Lugar de Nacimiento")]
        [Required]
        [MaxLength(100)]
        public string LugardeNacimiento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Domicilio { get; set; }

        [DisplayName("Correo Electrónico")]
        [Required]
        [MaxLength(150)]
        public string CorreoElectronico { get; set; }

        [DisplayName("Teléfono")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required!")]
        [MinLength(8)]
        [MaxLength(10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Formato incorrecto.")]
        public string Telefono { get; set; }
    }
}