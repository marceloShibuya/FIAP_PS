using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.PS.Cybertronics.Models;
using Fiap.PS.Cybertronics.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.PS.Cybertronics.Controllers
{
    public class ClienteController : Controller
    {
        private CrmContext _context;

        public ClienteController(CrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var cliente = _context.Clientes.Include(c => c.Produtos).Where(c => c.ClienteId == id).FirstOrDefault();
            return View(cliente);
        }

        public IActionResult Index(string nome)
        {
            var qtd = _context.Clientes.Count();
            ViewBag.qtd = qtd;

            var lista = _context.Clientes.Where(e => e.Nome.Contains(nome) || string.IsNullOrEmpty(nome)).ToList();
            ViewBag.clientes = lista;
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            TempData["msg"] = "Cliente cadastrado";
            return RedirectToAction("Index");
        }


    }
}
