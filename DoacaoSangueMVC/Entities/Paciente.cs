using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class Paciente 
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int IdUsuario { get; set; }
        public User Usuario { get; set; }
        public bool IsInternado { get; set; }
        public string NomeHospital { get; set; }
        public double NumeroLeito { get; set; }
        public string Diagnostico { get; set; }
        public int QuantidadeSangueSolicitada { get; set; }
        public DateTime DataDaTransfusao { get; set; }
        [ForeignKey("DadosMedico")]
        public int IdMedico { get; set; }
        public DadosMedico MedicoSolicitante { get; set; }
    }
}
