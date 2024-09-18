using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio.Interface
{
    public interface IVisitanteRepositorio
    {
        List<Visitante> BuscarVisitante();
        void InserirVisitante(Visitante visitante);
    }
}
