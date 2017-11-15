using AutoMapper;
using BookShare.Application.Interface;
using BookShare.Domain.Entities;
using BookShare.MVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BookShare.MVC.Controllers
{
    [Authorize]
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroApp;
        private readonly IAutorAppService _autorApp;
        private readonly ICategoriaAppService _categoriaApp;
        private readonly IEditoraAppService _editoraApp;
        public LivrosController(ILivroAppService livroApp, IAutorAppService autorApp, ICategoriaAppService categoriaApp, IEditoraAppService editoraApp)
        {
            _livroApp = livroApp;
            _autorApp = autorApp;
            _categoriaApp = categoriaApp;
            _editoraApp = editoraApp;
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
            //DateTime data = Convert.ToDateTime(livro.AnoLancamento, System.Globalization.CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
            //livro.AnoLancamento = data;
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);
            return View(livroViewModel);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            ViewBag.AutorId = new SelectList(_autorApp.GetAll(), "AutorId", "Nome");
            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            ViewBag.EditoraId = new SelectList(_editoraApp.GetAll(), "EditoraId", "Nome");
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
            catch (Exception ex)
            {
                return View(ex.Message);
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
            catch (Exception ex)
            {
                return View(ex.Message);
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
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var livro = _livroApp.GetById(id);
            _livroApp.Remove(livro);
            return RedirectToAction("Index");
        }
    }
}
