﻿using AutoMapper;
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
        public ActionResult Create(LivroViewModel livro, HttpPostedFileBase file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
                    if(file != null)
                    {
                        String[] strName = file.FileName.Split('.');
                        String strExt = strName[strName.Count() - 1];
                        string pathSave = String.Format("{0}{1}.{2}", Server.MapPath("../Content/Imagens/"), livro.LivroId, strExt);
                        String pathBase = String.Format("../Content/Imagens/{0}.{1}", livro.LivroId, strExt);
                        file.SaveAs(pathSave);
                        livroDomain.Foto = pathBase;
                        _livroApp.Add(livroDomain);
                    }
                    
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
            ViewBag.AutorId = new SelectList(_autorApp.GetAll(), "AutorId", "Nome");
            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            ViewBag.EditoraId = new SelectList(_editoraApp.GetAll(), "EditoraId", "Nome");
            var livro = _livroApp.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);
            return View(livroViewModel);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        public ActionResult Edit(LivroViewModel livro, HttpPostedFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
                    if (file != null)
                    {
                        if (livro.Foto != null)
                        {
                            if (System.IO.File.Exists(Server.MapPath("../../Content/Imagens/" + livro.Foto)))
                            {
                                System.IO.File.Delete(Server.MapPath("../../Content/Imagens/" + livro.Foto));
                            }
                        }
                        String[] strName = file.FileName.Split('.');
                        String strExt = strName[strName.Count() - 1];
                        string pathSave = String.Format("{0}{1}.{2}", Server.MapPath("../../Content/Imagens/"), livro.LivroId, strExt);
                        String pathBase = String.Format("../../Content/Imagens/{0}.{1}", livro.LivroId, strExt);
                        file.SaveAs(pathSave);
                        livro.Foto = pathBase;
                        

                    }
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
