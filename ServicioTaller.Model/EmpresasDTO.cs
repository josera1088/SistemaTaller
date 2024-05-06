using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTaller.Model
{
    public class EmpresasDTO
    {
        //[Key]
        //[Column("idEmpresa")]
        public int idEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        //[Column("nombreEmpresa")]
        public string nombreEmpresa { get; set; }

        [Required]
        [StringLength(500)]
        public string direccion { get; set; }

        [Required]
        [StringLength(50)]
        //[Column("correoelectronico")]
        public string correoelectronico { get; set; }

        [Required]
        [StringLength(20)]
        public string telefono { get; set; }

        [Required]
        [StringLength(30)]
        public string? cedula { get; set; } // Campo requerido pero puede ser nulo
    }
}
