using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Core_Conv2.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo apellido es requerido")]
        public string Apellido { get; set; }

        [StringLength(500)]
        public string Direccion { get; set; }

        [StringLength(12)]
        public string Telefono { get; set; }

        public int Edad { get; set; }

        public string Prueba { get; set; }
    }
}
