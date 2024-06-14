using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoacaoSangueMVC.Entities
{
    public class Doador 
    {
        public int Id { get; set; }
        public int VolumeColetado { get; set; }
        public string GrupoABO { get; set; }
        public bool FatorRh { get; set; }
        [ForeignKey("User")]
        public int IdUsuario { get; set; }
        public User Usuario { get; set; }

    }
}
