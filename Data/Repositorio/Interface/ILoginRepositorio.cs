using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio.Interface
{
    public interface ILoginRepositorio
    {
        Login Login(string usuario, string senha);
    }
}
