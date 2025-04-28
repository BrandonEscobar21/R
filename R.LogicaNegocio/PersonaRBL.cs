using R.AccesoDatos;
using R.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.LogicaNegocio
{
    public class PersonaRBL
    {
        readonly PersonaRDAL personaRDAL;
        public PersonaRBL(PersonaRDAL pPersonaRDAL)
        {
            personaRDAL = pPersonaRDAL;
        }

        public async Task<int> CrearAsync(PersonaR pPersonaR)
        {
            return await personaRDAL.CrearAsync(pPersonaR);
        }

        public async Task<int> ModificarAsync(PersonaR pPersonaR)
        {
            return await personaRDAL.ModificarAsync(pPersonaR);
        }

        public async Task<int> EliminarAsync(PersonaR pPersonaR)
        {
            return await personaRDAL.EliminarAsync(pPersonaR);
        }

        public async Task<PersonaR> ObtenerPorIdAsync(PersonaR pPersonaR)
        {
            return await personaRDAL.ObtenerPorIdAsync(pPersonaR);
        }

        public async Task<List<PersonaR>> ObtenerTodosAsync()
        {
            return await personaRDAL.ObtenerTodosAsync();
        }
    }
}
