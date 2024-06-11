using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class SangueColetado
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Hemocentro")]
        public int IdHemocentro { get; set; }
        public Hemocentro Hemocentro { get; set; }
        public DateTime DataColeta { get; set; }
        public string ComponenteSanguineo { get; set; }
        public double VolumeComponenteSanguineo { get; set; }
        [ForeignKey("Doador")]
        public int IdDoacao { get; set; }
        public Doador Doador { get; set; }
        public string NomeAnticoagulantePreservativo { get; set; }
        public int TemperaturaAdequada { get; set; }
        public DateTime DataVencimento { get; set; }
        public string GrupoABO { get; set; }
        public bool FatorRh { get; set; }
    }
}
