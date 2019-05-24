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
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(
                new Produto {
                    Id = 1,
                    Nome = "Produto1",
                    Descricao = "Descrição do Produto1"
                });
            return View(listaProdutos);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(Produto produto)
        {
            return View(produto);
        }

        public ActionResult Update(Produto produto)
        {
            return View(produto);
        }

        public ActionResult Delete(Produto produto)
        {
            return View(produto);
        }
    }
}