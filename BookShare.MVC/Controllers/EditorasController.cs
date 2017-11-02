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
    public class EditorasController : Controller
    {

        private readonly IEditoraAppService _editoraApp;

        public EditorasController(IEditoraAppService editoraApp)
        {
            _editoraApp = editoraApp;
        }
        // GET: Editoras
        public ActionResult Index()
        {
            var editoraViewModel = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModel>>(_editoraApp.GetAll());
            return View(editoraViewModel);
        }

        // GET: Editoras/Details/5
        public ActionResult Details(int id)
        {
            var editora = _editoraApp.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);
            return View(editoraViewModel);
        }

        // GET: Editoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editoras/Create
        [HttpPost]
        public ActionResult Create(EditoraViewModel editora)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var editoraDomain = Mapper.Map<EditoraViewModel, Editora>(editora);
                    _editoraApp.Add(editoraDomain);
                    return RedirectToAction("Index");
                }
                return View(editora);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        // GET: Editoras/Edit/5
        public ActionResult Edit(int id)
        {
            var editora = _editoraApp.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);
            return View(editoraViewModel);
        }

        // POST: Editoras/Edit/5
        [HttpPost]
        public ActionResult Edit(EditoraViewModel editora)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var editoraDomain = Mapper.Map<EditoraViewModel, Editora>(editora);
                    _editoraApp.Update(editoraDomain);
                    return RedirectToAction("Index");
                }
                return View(editora);

            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        // GET: Editoras/Delete/5
        public ActionResult Delete(int id)
        {
            var editora = _editoraApp.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);
            return View(editoraViewModel);
        }

        // POST: Editoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var editora = _editoraApp.GetById(id);
            _editoraApp.Remove(editora);
            return RedirectToAction("Index");
        }
    }
}
