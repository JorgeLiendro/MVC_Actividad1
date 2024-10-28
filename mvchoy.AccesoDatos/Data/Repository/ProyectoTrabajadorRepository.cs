using mvchoy.AccesoDatos.Data.Repository.IRepository;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository
{
    public class ProyectoTrabajadorRepository : Repository<ProyectoTrabajador>, IProyectoTrabajadorRepository
    {
        private readonly ApplicationDbContext _db;

        public ProyectoTrabajadorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProyectoTrabajador proyectoTrabajador)
        {
            var objDesdeDb = _db.ProyectoTrabajador
                .FirstOrDefault(s => s.CodProyecto == proyectoTrabajador.CodProyecto
                                     && s.Ci == proyectoTrabajador.Ci
                                     && s.CodProfesion == proyectoTrabajador.CodProfesion);

            if (objDesdeDb != null)
            {
                objDesdeDb.HorasTrabajadas = proyectoTrabajador.HorasTrabajadas;
                _db.SaveChanges(); // Si deseas guardar inmediatamente aquí, o llama en el servicio o capa de aplicación
            }
        }

        public IEnumerable<ProyectoTrabajador> GetByProyecto(int codProyecto)
        {
            return _db.ProyectoTrabajador.Where(pt => pt.CodProyecto == codProyecto).ToList();
        }

        public IEnumerable<ProyectoTrabajador> GetByTrabajador(long ci)
        {
            return _db.ProyectoTrabajador.Where(pt => pt.Ci == ci).ToList();
        }
    }
}
