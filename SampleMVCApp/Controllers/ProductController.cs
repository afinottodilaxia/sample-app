using SampleMVCApp.Models;
using SampleMVCApp.Services;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;

        public ProductController()
        {
            _service = new ProductService();
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _service.GetAll();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _service.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create() => View();

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prodotto prodotto)
        {
            if (ModelState.IsValid)
            {
                _service.Create(prodotto);
                return RedirectToAction("Index");
            }
            return View(prodotto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CreateProduct(Prodotto prodotto)
        {
            if (ModelState.IsValid)
            {
                _service.Create(prodotto);
                return Json(new { success = true });
            }

            // Return validation errors
            var errors = ModelState.Values.SelectMany(v => v.Errors)
                                           .Select(e => e.ErrorMessage)
                                           .ToList();
            return Json(new { success = false, errors });
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _service.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Prodotto prodotto)
        {
            if (ModelState.IsValid)
            {
                _service.Update(prodotto);
                return RedirectToAction("Index");
            }
            return View(prodotto);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _service.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
