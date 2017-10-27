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
    public class CategoriasController : Controller
    {
        private readonly ICategoriaAppService _categoriaApp;
        public CategoriasController(ICategoriaAppService categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }
        // GET: Categorias
        public ActionResult Index()
        {
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll());
            return View(categoriaViewModel);
        }

        // GET: Categorias/Details/5
        public ActionResult Details(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoria)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                    _categoriaApp.Add(categoriaDomain);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoriaViewModel categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                    _categoriaApp.Update(categoriaDomain);
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }

        // POST: Categorias/Delete/5
        [HttpPost]
        public ActionResult Delete(CategoriaViewModel categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                    _categoriaApp.Remove(categoriaDomain);
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
