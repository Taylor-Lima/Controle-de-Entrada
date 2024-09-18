using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio
{
    public class VisitanteRepositorio : IVisitanteRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public VisitanteRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Visitante> BuscarVisitante()
        {
            return _bancoContexto.Visitante.ToList();
        }
        public void InserirVisitante(Visitante visitante)
        {
            _bancoContexto.Visitante.Add(visitante);
            _bancoContexto.SaveChanges();
        }


    }
}
