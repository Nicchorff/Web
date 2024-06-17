namespace DoacaoSangueMVC.Models
{
    public class InformacaoAngedamentoDTO
    {
        public DateTime Data { get; set; }
        public string TipoSanguineo { get; set; }
        public string NomeHemocentro { get; set; }
        public bool Status {  get; set; }
    }
}
