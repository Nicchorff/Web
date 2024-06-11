using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class ProcedimentoAfereseDoador
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Doador")]
        public int IdDoador { get; set; }
        public Doador Doador { get; set; }
        public required string TipoComponenteSanguineo { get; set; }
        public double VolumeProduto { get; set; }
        public required string AnticoagulanteUsado { get; set; }
        public int HoraDaColeta { get; set; }
    }
}
