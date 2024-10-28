using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.Models
{
    public class Trabajador
    {
        [Key]
        public int CodTrabajador { get; set; }
        public long Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

    }
}
