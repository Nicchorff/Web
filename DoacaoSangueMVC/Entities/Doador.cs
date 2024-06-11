using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class Doador
    {
        [Key]
        public int Id { get; set; }
        public string TipoDoacao { get; set; }
        public double HT { get; set; }
        public double PressaoArterialSistolica { get; set; }
        public double PressaoArterialDiastolica { get; set; }
        public int Temperatura { get; set; }
        public int VolumeColetar { get; set; }

        public ICollection<ProcedimentoAfereseDoador> ProcedimentosAferese { get; set; }
    }
}
