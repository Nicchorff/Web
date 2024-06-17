namespace DoacaoSangueMVC.Models
{
    public class AgendamentoDTO
    {
        public string NomeHemocentro { get; set; } = string.Empty;
        public TimeOnly hora { get; set; } = default;
        public DateOnly data { get; set; }
        public string AuthenticationTypeUser { get; set; } = default;
        public int IdHemocentro { get; set; } 
    }
}
