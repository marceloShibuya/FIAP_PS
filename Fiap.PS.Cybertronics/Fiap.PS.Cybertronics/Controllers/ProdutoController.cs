﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.PS.Cybertronics.Models;
using Fiap.PS.Cybertronics.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.PS.Cybertronics.Controllers
{
    public class ProdutoController : Controller
    {
        private CrmContext _context;

        public ProdutoController(CrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var lista = _context.Produtos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            TempData["msg"] = "Produto cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            TempData["msg"] = "Produto atualizado";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            TempData["msg"] = "Produto apagado";
            return RedirectToAction("Index");
        }
        public IActionResult Index(TipoServico tipo)
        {
            var qtd = _context.Produtos.Count();
            ViewBag.qtd = qtd;

            var lista = _context.Produtos.Where(p => p.TipoServico == tipo || tipo == 0).OrderBy(p => p.Preco).ToList();
            return View(lista);
        }
    }
}