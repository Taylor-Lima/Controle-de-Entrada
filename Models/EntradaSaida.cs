namespace Controle_Entrada.Models
{
    public class EntradaSaida
    {
        public int Id { get; set; }
        public int VisitanteId { get; set; }
        public int IdVisitante { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; } // Pode ser nulo até que a saída seja registrada
    }

}

