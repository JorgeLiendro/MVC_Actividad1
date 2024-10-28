using Microsoft.EntityFrameworkCore;
using mvchoy.AccesoDatos.Data.Repository.IRepository;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository
{
    public class ProyectoRepository : Repository<Proyecto>, IProyectoRepository
    {
        private readonly ApplicationDbContext _db;

        public ProyectoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Proyecto proyecto)
        {
            var objDesdeDb = _db.Proyecto.FirstOrDefault(s => s.CodProyecto == proyecto.CodProyecto);
            if (objDesdeDb != null)
            {
                objDesdeDb.Nombre = proyecto.Nombre;
                objDesdeDb.FechaInicio = proyecto.FechaInicio;
                objDesdeDb.FechaFinalizacion = proyecto.FechaFinalizacion;
                objDesdeDb.FechaFinPlanificado = proyecto.FechaFinPlanificado;
                objDesdeDb.CodEmpresa = proyecto.CodEmpresa;  // Actualiza la clave foránea si es necesario

                _db.SaveChanges();
            }
        }

        public Proyecto GetWithEmpresa(int id)
        {
            // Carga un proyecto específico junto con su empresa relacionada
            return _db.Proyecto.Include(p => p.Empresa).FirstOrDefault(p => p.CodProyecto == id);
        }
    }
}
