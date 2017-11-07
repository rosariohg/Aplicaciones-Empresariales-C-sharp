using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Everfreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-27"),
                Email = "maria@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av.Los manzanos 101",
                FechaNac = Convert.ToDateTime("1992-02-14"),
                Email = "carlos@gmail.com"
            });
            return View(personas);
        }
        public ActionResult Mostrar (int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Everfreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-27"),
                Email = "maria@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av.Los manzanos 101",
                FechaNac = Convert.ToDateTime("1992-02-14"),
                Email = "carlos@gmail.com"
            });
            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }

    }
}