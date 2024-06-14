using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class ABO
    {
        [Key]
        public int ID { get; set; }
        public string TipoSanguineo { get; set; }
        public bool IsPositivo { get; set; }
    }
}
