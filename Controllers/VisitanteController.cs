using Controle_Entrada.Data.Repositorio.Interface;
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
    }
}
