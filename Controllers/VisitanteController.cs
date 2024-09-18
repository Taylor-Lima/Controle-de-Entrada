using Controle_Entrada.Data.Repositorio;
using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Entrada.Controllers
{
    public class VisitanteController : Controller
    {
        private readonly IVisitanteRepositorio _visitanteRepositorio;
        public VisitanteController(IVisitanteRepositorio visitanteRepositorio)
        {
            _visitanteRepositorio = visitanteRepositorio;
        }
        public IActionResult Index()
        {
            var visitante = _visitanteRepositorio.BuscarVisitante();
            return View(visitante);
        }
        public IActionResult AdicionarVisitante()
        {
            return View();
        }
        public IActionResult InserirVisitante(Visitante visitante)
        {
            try
            {
                _visitanteRepositorio.InserirVisitante(visitante);


            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
