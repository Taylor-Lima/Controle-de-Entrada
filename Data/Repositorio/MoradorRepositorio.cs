using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio
{
    public class MoradorRepositorio : IMoradorRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public MoradorRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Morador> BuscarMorador()
        {
            return _bancoContexto.Morador.ToList();
        }
        public void InserirMorador(Morador morador) 
        { 
            _bancoContexto.Morador.Add(morador);
            _bancoContexto.SaveChanges();
        }

    }
}
