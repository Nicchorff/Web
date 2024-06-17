using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoacaoSangueMVC.Entities
{
    public class DoacoesAgendadas
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataDoacao { get; set; }
        public string TipoSanguineo { get; set; }
        [ForeignKey("Hemocentro")]
        public int IdHemocentro{ get; set; }
        [ForeignKey("AspNetUsers")]
        public int IdUsuario { get; set; }
        public bool Status { get; set; }
    }

}
