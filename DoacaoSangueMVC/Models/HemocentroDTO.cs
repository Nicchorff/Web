using DoacaoSangueMVC.Entities;

namespace DoacaoSangueMVC.Models
{
    public class HemocentroDTO
    {
        public Hemocentro Hemocentro { get; set; }
        public IList<string> TipoSanguineoFaltando { get; set; }
    }
}
