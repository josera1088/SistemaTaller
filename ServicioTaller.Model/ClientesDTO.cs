using ServicioTaller.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTaller.Model
{
    public class ClientesDTO
    {
        public class Cliente
        {
  
           // [Column("id_TB_Clientes")]
            public int Id { get; set; }

            //[Column("idEmpresa")]
            public int? IdEmpresa { get; set; }

            [Required]
            [StringLength(15)]
            public string? cedula { get; set; }

            [Required]
            [StringLength(50)]
            public string? nombre { get; set; }

            [Required]
            [StringLength(50)]
           // [Column("primerApellido")]
            public string? primerApellido { get; set; }

            [Required]
            [StringLength(50)]
            //[Column("segundoApellido")]
            public string? segundoApellido { get; set; }

            [Required]
            [StringLength(500)]
            public string? descripcion { get; set; }

            public bool? estado { get; set; }

            //[Column("usuarioIngresa")]
            public int? usuarioIngresa { get; set; }

            //[Column("fechaIngresa")]
            public DateTime? fechaIngresa { get; set; }

            //[Column("usuarioModifica")]
            public int? usuarioModifica { get; set; }

            //[Column("fechaModifica")]
            public DateTime? fechaModifica { get; set; }


            // Relación con la tabla TB_Empresa
            [ForeignKey("IdEmpresa")]
            public Empresa? Empresa { get; set; }
        }
    }
}
