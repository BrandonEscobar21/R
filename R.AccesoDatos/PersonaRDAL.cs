using Microsoft.EntityFrameworkCore;
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

        public async Task<int> CrearAsync(PersonaR pPersonaR)
        {
            PersonaR personaR = new PersonaR()
            {
                NombreR = pPersonaR.NombreR,
                ApellidoR = pPersonaR.ApellidoR,
                FechaNacimientoR = pPersonaR.FechaNacimientoR,
                SueldoR = pPersonaR.SueldoR,
                EstatusR = pPersonaR.EstatusR
            };
            dbContext.PersonaR.Add(personaR);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> ModificarAsync(PersonaR pPersonaR)
        {
            var personaR = await dbContext.PersonaR.FirstOrDefaultAsync(s => s.Id == pPersonaR.Id);
            if (personaR != null && personaR.Id != 0)
            {
                personaR.NombreR = pPersonaR.NombreR;
                personaR.ApellidoR = pPersonaR.ApellidoR;
                personaR.FechaNacimientoR = pPersonaR.FechaNacimientoR;
                personaR.SueldoR = pPersonaR.SueldoR;
                personaR.EstatusR = pPersonaR.EstatusR;

                dbContext.Update(personaR);
                return await dbContext.SaveChangesAsync();
            }
            else
                return 0;
        }

        public async Task<int> EliminarAsync(PersonaR pPersonaR)
        {
            var personaR = await dbContext.PersonaR.FirstOrDefaultAsync(s => s.Id == pPersonaR.Id);
            if (personaR != null && personaR.Id != 0)
            {
                dbContext.PersonaR.Remove(personaR);
                return await dbContext.SaveChangesAsync();
            }
            else
                return 0;
        }

        public async Task<PersonaR> ObtenerPorIdAsync(PersonaR pPersonaR)
        {
            var personaR = await dbContext.PersonaR.FirstOrDefaultAsync(s => s.Id == pPersonaR.Id);
            if (personaR != null && personaR.Id != 0)
            {
                return new PersonaR
                {
                    Id = personaR.Id,
                    NombreR = personaR.NombreR,
                    ApellidoR = personaR.ApellidoR,
                    FechaNacimientoR = personaR.FechaNacimientoR,
                    SueldoR = personaR.SueldoR,
                    EstatusR = personaR.EstatusR,
                };
            }
            else
                return new PersonaR();
        }

        public async Task<List<PersonaR>> ObtenerTodosAsync()
        {
            var personaR = await dbContext.PersonaR.ToListAsync();
            if (personaR != null && personaR.Count > 0)
            {
                var list = new List<PersonaR>();
                personaR.ForEach(p => list.Add(new PersonaR
                {
                    Id = p.Id,
                    NombreR = p.NombreR,
                    ApellidoR = p.ApellidoR,
                    FechaNacimientoR = p.FechaNacimientoR,
                    SueldoR = p.SueldoR,
                    EstatusR = p.EstatusR
                }));
                return list;
            }
            else
                return new List<PersonaR>();
        }
    }
}
