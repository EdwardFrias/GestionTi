using GestionTi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionTi.Controllers
{
    public class CandidatoController : Controller
    {
        // GET: Candidato
        public ActionResult Index()
        {
            try
            {
                using (var db = new CandidatosContext())
                {
                    return View(db.Candidatos.ToList());
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Candidatos ca)
        {

            if (!ModelState.IsValid)
                return View();

            try
            {
                using (CandidatosContext db = new CandidatosContext())
                {

                    db.Candidatos.Add(ca);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                //return View();
            }
            catch (Exception ex)
            {

                 ModelState.AddModelError("Error al agregar Candidato", ex);
                return View();
            }


        }

        public ActionResult Editar(int id)
        {
            using (var db = new CandidatosContext())
            {
                Candidatos ca = db.Candidatos.Find(id);
                return View(ca);
            }
               
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Candidatos ca)
        {

            if (!ModelState.IsValid)
                return View();

            try
            { 
                using(var db = new CandidatosContext())
                {
                    Candidatos cand = db.Candidatos.Find(ca.Candidatos_Id);
                    cand.Candidatos_Cedula = ca.Candidatos_Cedula;
                    cand.Candidatos_Nombre = ca.Candidatos_Nombre;
                    cand.Candidatos_Apellido = ca.Candidatos_Apellido;
                    cand.Candidatos_FechaNacimiento = ca.Candidatos_FechaNacimiento;
                    cand.Candidatos_TrabajoActual = ca.Candidatos_TrabajoActual;
                    cand.Candidatos_ExpectativaSalarial = ca.Candidatos_ExpectativaSalarial;
                    cand.Candidatos_Observaciones = ca.Candidatos_Observaciones;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                } 
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public ActionResult Detalles(int id)
        {
            using (var db = new CandidatosContext())
            {
                Candidatos ca = db.Candidatos.Find(id);
                return View(ca);
            }
        }

        public ActionResult Eliminar(int id)
        {
            using (var db = new CandidatosContext())
            {
                Candidatos ca = db.Candidatos.Find(id);
                db.Candidatos.Remove(ca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}