using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio.Interface
{
    public interface IMoradorRepositorio
    {
        List<Morador> BuscarMorador();
        void InserirMorador(Morador morador);

    }
}
