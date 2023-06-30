using Domain.Persona;
using Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion.Controllers
{
    public class PersonaController : Controller
    {
        PersonaDomain domain = new PersonaDomain();
        public ActionResult Index()
        {
            ViewBag.Personas = domain.GetAllPersonas();
            return View();
        }

        public ActionResult Create()
        {
            LoadCombos();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Personas persona)
        {
            if(ModelState.IsValid)
            {
                string validate = domain.ValidateCreatePersona(persona);
                if(string.IsNullOrEmpty(validate))
                {
                    LoadCombos();
                    ViewBag.Valido = true;
                    domain.CreatePersona(persona);
                    return View();
                }
                else
                {
                    ViewBag.Error = true;
                    ModelState.AddModelError(string.Empty, validate);
                    LoadCombos();
                    return View(persona);
                }
            }
            else
            {
                LoadCombos();
                return View(persona);
            }
        }

        [NonAction]
        public void LoadCombos()
        {
            Dictionary<string, string> tiposIdentificacion = new Dictionary<string, string>();
            tiposIdentificacion.Add(TiposIdentificacion.CedulaCiudadania.ToString(), "Cedula de Ciudadania");
            tiposIdentificacion.Add(TiposIdentificacion.CedulaExtrajenria.ToString(), "Cedula de Extrajenria");
            tiposIdentificacion.Add(TiposIdentificacion.Pasaporte.ToString(), "Pasaporte");
            tiposIdentificacion.Add(TiposIdentificacion.TarjetaIdentidad.ToString(), "Tarjeta de Identidad");
            ViewBag.TiposIdentificacion = tiposIdentificacion;
        }
    }
}