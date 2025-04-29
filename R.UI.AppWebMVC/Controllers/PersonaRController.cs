using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R.EntidadesNegocio;
using R.LogicaNegocio;

namespace R.UI.AppWebMVC.Controllers
{
    public class PersonaRController : Controller
    {
        readonly PersonaRBL _personaRBL;
        public PersonaRController(PersonaRBL pPersonaRBL)
        {
            _personaRBL = pPersonaRBL;
        }
        // GET: PersonaRController
        public async Task<ActionResult> Index()
        {
            var personaR = await _personaRBL.ObtenerTodosAsync();
            return View(personaR);
        }

        // GET: PersonaRController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaRController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaRController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaR pPersonaR)
        {
            try
            {
                var result = await _personaRBL.CrearAsync(pPersonaR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaRController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personaR = await _personaRBL.ObtenerPorIdAsync(new PersonaR { Id = id });

            return View(personaR);
        }

        // POST: PersonaRController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaR pPersonaR)
        {
            try
            {
                var result = await _personaRBL.ModificarAsync(pPersonaR);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaRController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personaR = await _personaRBL.ObtenerPorIdAsync(new PersonaR { Id = id });
            return View(personaR);
        }

        // POST: PersonaRController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeletePersonaR(int id)
        {
            try
            {
                var resul = await _personaRBL.EliminarAsync(new PersonaR { Id = id });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
