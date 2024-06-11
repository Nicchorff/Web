using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class Hemocentro
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double CEP { get; set; }
        public string Referencia { get; set; }
        public string NomeHemocentro { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
