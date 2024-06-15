using DoacaoSangueMVC.Entities;

namespace DoacaoSangueMVC.Models
{
    public class BancoDeSangueDTO
    {
        public ABO TipoSanguineo { get; set; }
        public string NomeHemocentro { get; set; }
        public double Quantidade { get; set; }
        public double MediaDoSangue { get; set; }
    }
}
