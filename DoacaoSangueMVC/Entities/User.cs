using Microsoft.AspNetCore.Identity;

namespace DoacaoSangueMVC.Entities
{
    public class User : IdentityUser
    {
        public double CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public required string OrgaoExpedidor { get; set; }
        public required string Naturalidade { get; set; }
        public required string Nacionalidade { get; set; }
        public required string NomeDaMae { get; set; }
        public required string NomeDoPai { get; set; }
        public required string Emprego { get; set; }
        public double CEP { get; set; }
        public required string ABO { get; set; }
        public bool IsPositivo { get; set; }
        public bool IsNegativo { get; set; }
        public required string Sexo { get; set; }
        public required string Endereco { get; set; }
    }
}
