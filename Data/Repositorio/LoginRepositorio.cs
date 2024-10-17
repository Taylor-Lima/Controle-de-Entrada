using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public LoginRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;

        }
        public Login Login(string usuario, string senha) 
        {
            return _bancoContexto.Login.SingleOrDefault(x => x.Usuario == usuario && x.Senha == senha);
        }
    }
}
     
   

