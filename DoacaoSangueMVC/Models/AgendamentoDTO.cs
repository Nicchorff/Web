namespace DoacaoSangueMVC.Models
{
    public class AgendamentoDTO
    {
        public TimeOnly hora { get; set; }
        public DateOnly data { get; set; }
        public string AuthenticationTypeUser { get; set; }
        public int IdHemocentro { get; set; }
    }
}
