using AutoMapper;
using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using BookShare.MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BookShare.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroApp;
        public LivrosController(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }
        // GET: Livros
        public ActionResult Index()
        {
            var livroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroApp.GetAll());
            return View(livroViewModel);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);
            return View(livroViewModel);
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
                    _livroApp.Add(livroDomain);
                    return RedirectToAction("Index");
                }
                return View(livro);
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);
            return View(livroViewModel);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        public ActionResult Edit(LivroViewModel livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
                    _livroApp.Update(livroDomain);
                    return RedirectToAction("Index");
                }
                return View(livro);
            }
            catch
            {
                return View();
            }
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);
            return View(livroViewModel);
        }

        // POST: Livros/Delete/5
        [HttpPost]
        public ActionResult Delete(LivroViewModel livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
                    _livroApp.Remove(livroDomain);
                    return RedirectToAction("Index");
                }
                return View(livro);
            }
            catch
            {
                return View();
            }
        }
    }
}
