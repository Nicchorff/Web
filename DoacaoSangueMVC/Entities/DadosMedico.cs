using System.ComponentModel.DataAnnotations;

namespace DoacaoSangueMVC.Entities
{
    public class DadosMedico
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public double CRM { get; set; }
    }
}
