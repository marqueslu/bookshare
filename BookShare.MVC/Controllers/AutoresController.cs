using AutoMapper;
using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using BookShare.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShare.MVC.Controllers
{
    public class AutoresController : Controller
    {

        private readonly IAutorAppService _autorApp;

        public AutoresController(IAutorAppService autorApp) 
        {
            _autorApp = autorApp;
        }

        // GET: Autor
        public ActionResult Index()
        {
            var autorViewModel = Mapper.Map<IEnumerable<Autor>, IEnumerable<AutorViewModel>>(_autorApp.GetAll()); 
            return View(autorViewModel);
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);
            return View(autorViewModel);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        public ActionResult Create(AutorViewModel autor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var autorDomain = Mapper.Map<AutorViewModel, Autor>(autor);
                    _autorApp.Add(autorDomain);
                    return RedirectToAction("Index");
                }

                return View(autor);
            }
            catch(Exception e)
            {
                return View(e.Message);
            }
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel> (autor);
            return View(autorViewModel);
        }

        // POST: Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(AutorViewModel autor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var autorDomain = Mapper.Map<AutorViewModel, Autor>(autor);
                    _autorApp.Update(autorDomain);
                    return RedirectToAction("Index");
                }

                return View(autor);
                
            }
            catch(Exception e)
            {
                return View(e.Message);
            }
        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);
            return View(autorViewModel);
        }

        // POST: Autor/Delete/5
        [HttpPost]
        public ActionResult Delete(AutorViewModel autor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var autorDomain = Mapper.Map<AutorViewModel, Autor>(autor);
                    _autorApp.Remove(autorDomain);
                    return RedirectToAction("Index");
                }
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View(e.Message);
            }
        }
    }
}
