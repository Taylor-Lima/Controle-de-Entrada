using Controle_Entrada.Data.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Entrada.Controllers
{

    public class RelatorioController : Controller
    {
        private readonly IRelatorioRepositorio _relatorioRepositorio;

        public RelatorioController(IRelatorioRepositorio relatorioRepositorio)
        {
            _relatorioRepositorio = relatorioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscarMorador()
        {
            var morador = _relatorioRepositorio.BuscarMorador();
            return View(morador);
        }
    }
}