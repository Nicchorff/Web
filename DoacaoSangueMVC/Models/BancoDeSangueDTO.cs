using DoacaoSangueMVC.Entities;

namespace DoacaoSangueMVC.Models
{
    public class BancoDeSangueDTO
    {
        public ABO TipoSanguineo { get; set; }
        public string NomeHemocentro { get; set; }
        public double QuantidadeNoEstoque { get; set; }
        public double MediaDeSangueNoEstoque { get; set; }
        public double QuantidadeMinímaSugerida { get; set; } = 50;
    }
}
