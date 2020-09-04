using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class ResultadoController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(ResultadoModel model)
        {
            model.Retorno = Funcoes.palavraTriangulo(model.Palavra).ToString();
            if (model.Retorno == "-1")
                ViewBag.Label = model.Retorno + " Palavra não triângulo." ;
            else
                ViewBag.Label = "Palavra triângulo, posição: " + model.Retorno ;
            return View();
        }
    }
}