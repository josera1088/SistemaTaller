using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTaller.Model.Models
{
  
        public class ResponseAPI<T>
        {
            public bool indCorrecto { get; set; }
            public T? Valor { get; set; }
            public string? Mensaje { get; set; }
        }
   }

