using Microsoft.EntityFrameworkCore;
using R.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.AccesoDatos
{
    public class RDbContext : DbContext
    {
        public RDbContext(DbContextOptions<RDbContext> options) : base(options)
        {

        }
        public DbSet<PersonaR> PersonaR { get; set; }

    }
}
