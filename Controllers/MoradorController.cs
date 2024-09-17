using Controle_Entrada.Data.Repositorio;
using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Entrada.Controllers
{
    public class MoradorController : Controller
    {
        private readonly IMoradorRepositorio _moradorRepositorio;

        public MoradorController(IMoradorRepositorio moradorRepositorio)
        {
            _moradorRepositorio = moradorRepositorio;
        }
        public IActionResult Index()
        {
            var morador = _moradorRepositorio.BuscarMorador();
            return View(morador);
        }
        public IActionResult AdicionarMorador()
        {
            return View();
        }
        public IActionResult InserirMorador(Morador morador)
        {
            try
            {
                _moradorRepositorio.InserirMorador(morador);


            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
    }
}
