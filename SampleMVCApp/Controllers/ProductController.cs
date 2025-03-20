using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _repository = new ProductRepository();

        // GET: Product
        public ActionResult Index()
        {
            var products = _repository.GetAll();
            return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _repository.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create() => View();

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _repository.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = _repository.GetById(id.Value);
            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        // Esempio: chiamata a un'API esterna
        public ActionResult FetchExternalData()
        {
            // Questo esempio semplificato consente di verificare come Copilot suggerisca la gestione di chiamate HTTP.
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = client.GetAsync("https://jsonplaceholder.typicode.com/posts").Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    ViewBag.ApiData = data;
                }
            }
            return View();
        }
    }
}
