using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Charts()
        {
            return View();
        }

        public ActionResult ListaDellaSpesa(int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            using (var db = new ApplicationDbContext())
            {
                var prodotti = db.Prodotti.OrderBy(p => p.Id).ToPagedList(pageNumber, pageSize);
                var viewModel = new ListaDellaSpesaViewModel
                {
                    Prodotti = prodotti,
                    NuovoProdotto = new Prodotto()
                };
                return View(viewModel);
            }
        }
    }
}