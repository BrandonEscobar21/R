using R.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.AccesoDatos
{
    public class PersonaRDAL
    {
        readonly RDbContext dbContext;
        public PersonaRDAL(RDbContext RDB)
        {
            dbContext = RDB;
        }
    }
}
