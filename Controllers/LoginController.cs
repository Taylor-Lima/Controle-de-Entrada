using Controle_Entrada.Data.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Controle_Entrada.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;
        public LoginController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidarLogin(string usuario, string senha) 
        {
            var login = _loginRepositorio.Login(usuario, senha);
            if (login != null) 
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email ou senha inválidos.");
                return View("Index");
            }
        }
    }
}
