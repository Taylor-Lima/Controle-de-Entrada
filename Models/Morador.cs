namespace Controle_Entrada.Models
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public string PlacaVeiculo { get; set; }
        public string Telefone { get; set; }
        public DateTime Hora { get; set; }
        //public Teste teste { get; set; 
    }
    }
    //public class Teste
    //{
    //    public int IdTeste { get; set; }
    //}
    //}








//CREATE TABLE Morador (
//Id INT IDENTITY(1,1) NOT NULL,
//Nome VARCHAR(30) NOT NULL,
//Unidade VARCHAR(20) NOT NULL,
//PlacaVeiculo VARCHAR(7) NOT NULL,
//Telefone VARCHAR(11) NOT NULL,
//Hora Datetime NOT NULL,
//)


//CREATE TABLE Visitante (
//Id INT IDENTITY(1,1) NOT NULL,
//Nome VARCHAR(30) NOT NULL,
//Documento VARCHAR(20) NOT NULL,
//Hora DATETIME DEFAULT GETDATE() NOT NULL,
//)