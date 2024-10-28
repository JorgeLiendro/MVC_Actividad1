using mvchoy.AccesoDatos.Data.Repository.IRepository;
using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository
{
    public class EmpresaRepository : Repository<Empresa>, IEmpresaRepository
    {
        private readonly ApplicationDbContext _db;

        public EmpresaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Empresa empresa)
        {
            var objDesdeDb = _db.Empresa.FirstOrDefault(s => s.CodEmpresa == empresa.CodEmpresa);
            objDesdeDb.Nombre = empresa.Nombre;
            objDesdeDb.Nit = empresa.Nit;
            objDesdeDb.Direccion = empresa.Direccion;
            objDesdeDb.Telefono = empresa.Telefono;

            _db.SaveChanges();
        }

    }
}
