namespace Controle_Entrada.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public string Oberservacao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }

}

