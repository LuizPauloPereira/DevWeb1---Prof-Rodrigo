using DevWeb1___Prof_Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevWeb1___Prof_Rodrigo.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }


        // POST: Produto
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}