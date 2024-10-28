using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.Models
{
    public class ProyectoTrabajador
    {
        public int CodProyecto { get; set; }
        public long Ci { get; set; }
        public int CodProfesion { get; set; }
        public int HorasTrabajadas { get; set; }

        //foraneos
        public virtual Proyecto Proyecto { get; set; }
        public virtual Trabajador Trabajador { get; set; }
        public virtual Profesion Profesion { get; set; }

    }
}
