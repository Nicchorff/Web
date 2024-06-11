using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class ProcedimentoPaciente
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public string Diagnostico { get; set; }
        public string ProcedimentoTerapeutico { get; set; }
        public int VolumeExtracorporeoProcessado { get; set; }
        public string TipoComponente { get; set; }
        public int VolumeComponente { get; set; }
        public int TipoLiquido { get; set; }
        public int VolumeLiquido { get; set; }
    }
}
