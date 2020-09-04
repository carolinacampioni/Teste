using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Teste de Analista Programador";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Resumo de Histórico Profissional.";

            return View();
        }

    }
}