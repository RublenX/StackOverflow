using CapasMvc5.CapaNegocios.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CapasMvc5.ProductoCapas.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public async Task<ActionResult> Index()
        {
            return View(await CategoriaBL.ListarCategoriasAsync());
        }

        //// GET: Categorias/Details/5
        //public async Task<ActionResult> Details(int id)
        //{
        //    return View();
        //}

        //// GET: Categorias/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Categorias/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public Task<ActionResult> Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Categorias/Edit/5
        //public async Task<ActionResult> Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Categorias/Edit/5
        //[HttpPost]
        //public async Task<ActionResult> Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Categorias/Delete/5
        //public async Task<ActionResult> Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Categorias/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
