using mvchoy.AccesoDatos.Data.Repository.IRepository;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository
{
    public class TrabajadorRepository : Repository<Trabajador>, ITrabajadorRepository
    {
        private readonly ApplicationDbContext _db;

        public TrabajadorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Trabajador trabajador)
        {
            var objDesdeDb = _db.Trabajador.FirstOrDefault(s => s.CodTrabajador == trabajador.CodTrabajador);
            objDesdeDb.Ci = trabajador.Ci;
            objDesdeDb.Nombre = trabajador.Nombre;
            objDesdeDb.Apellido = trabajador.Apellido;
            objDesdeDb.Direccion = trabajador.Direccion;

            _db.SaveChanges();
        }

    }
}
