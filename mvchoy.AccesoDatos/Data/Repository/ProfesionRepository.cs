using mvchoy.AccesoDatos.Data.Repository.IRepository;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository
{
    public class ProfesionRepository : Repository<Profesion>, IProfesionRepository
    {
        private readonly ApplicationDbContext _db;

        public ProfesionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Profesion profesion)
        {
            var objDesdeDb = _db.Profesion.FirstOrDefault(s => s.CodProfesion == profesion.CodProfesion);
            objDesdeDb.Nombre = profesion.Nombre;


            _db.SaveChanges();
        }

    }
}
