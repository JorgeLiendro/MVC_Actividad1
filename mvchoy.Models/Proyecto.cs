using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.Models
{
    public class Proyecto
    {
        [Key]
        public int CodProyecto { get; set; }
        public int CodEmpresa { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime FechaFinPlanificado { get; set; }

        //foraneo
        public virtual Empresa Empresa { get; set; }


    }
}
