using Controle_Entrada.Data.Repositorio.Interface;
using Controle_Entrada.Models;

namespace Controle_Entrada.Data.Repositorio
{
    public class RelatorioRepositorio : IRelatorioRepositorio
    {
        private readonly BancoContexto _bancoContexto;

    public RelatorioRepositorio(BancoContexto bancoContexto)
    {
        _bancoContexto = bancoContexto;
    }

    public List<Morador> BuscarMorador()
    {
        return _bancoContexto.Morador.ToList();
    }
  

}
}
