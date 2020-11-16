using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.PS.Cybertronics.Models;
using Fiap.PS.Cybertronics.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.PS.Cybertronics.Controllers
{
    public class EmpresaController : Controller
    {
        private CrmContext _context;

        public EmpresaController(CrmContext context)
        {
            _context = context;
        }

        public IActionResult Index(string nome)
        {
            var lista = _context.Empresas.Where(e => e.Nome.Contains(nome) || string.IsNullOrEmpty(nome)).ToList();
            ViewBag.empresas = lista;
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
            TempData["msg"] = "Empresa cadastrada";
            return RedirectToAction("Index");
        }

    }
}
