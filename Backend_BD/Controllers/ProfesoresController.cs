using Backend_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Backend_BD.Controllers
{
    public class ProfesoresController : Controller
    {
        // GET: Profesores
        public ActionResult Index()
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {
                return View(dbProfesores.Profesores.ToList());

            }
        }
        public ActionResult Details(int id)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {

                Profesores profesores = dbProfesores.Profesores.Find(id);
                if (profesores == null)
                {
                    return HttpNotFound();
                }
                return View(profesores);
            }
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profesores profes)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {


                dbProfesores.Profesores.Add(profes);
                dbProfesores.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {
                return View(dbProfesores.Profesores.Where(x => x.Id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(Profesores profes)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {
                dbProfesores.Entry(profes).State = EntityState.Modified;
                dbProfesores.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {
                return View(dbProfesores.Profesores.Where(x => x.Id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(Profesores Profes, int id)
        {
            using (AlumnoDBContext dbProfesores = new AlumnoDBContext())
            {
                Profesores prof = dbProfesores.Profesores.Where(x => x.Id == id).FirstOrDefault();
                dbProfesores.Profesores.Remove(prof);
                dbProfesores.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}