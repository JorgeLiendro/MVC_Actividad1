using mvchoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchoy.AccesoDatos.Data.Repository.IRepository
{
    public interface IProfesionRepository : IRepository<Profesion>
    {
        void Update(Profesion profesion);
    }
}
