using AutoMapper;
using BookShare.Domain.Entities;
using BookShare.Infra.Data.Repositories;
using BookShare.MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BookShare.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroRepository _livroRepository = new LivroRepository(); 
        // GET: Livros
        public ActionResult Index()
        {
            var livroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroRepository.GetAll());
            return View(livroViewModel);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
                    _livroRepository.Add(livroDomain);
                    return RedirectToAction("Index");
                }
                return View(livro);
                // TODO: Add insert logic here

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Livros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Livros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
