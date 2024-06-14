using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class BancoDeSangue
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Hemocentro")]
        public int IdHemocentro { get; set; }
        public Hemocentro Hemocentro { get; set; }
        [ForeignKey("Doador")]
        public int IdDoacao { get; set; }
        public Doador Doador { get; set; }  
        public DateTime Data { get; set; }
    }
}
