namespace Controle_Entrada.Models
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int IdMorador { get; set; }
    }
}

