using System.Xml;

namespace SistemaListagem.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public string? email { get; set; }
        public string? genero { get; set; }
        public string? cidade { get; set; }
        public string? pais { get; set; }
        public string? urlfoto { get; set; }
    
    }
}
