﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaGames.Models;
using ProjetoLojaJogos.Models;

namespace ProjetoLojaJogos.Controllers
{
    public class FuncController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("ListarFuncionario", funcionario);
            }
            return View(funcionario);
        }
    }
}