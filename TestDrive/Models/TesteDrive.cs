using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestDrive.Models
{
    public class TesteDrive
    {
        [Required(ErrorMessage = "Informe o nome do vendedor")]
        public string NameVendedor { get; set; }
        [Required(ErrorMessage = "Informe a data do test drive")]
        public DateTime DataTestDrive { get; set; }
        [Required(ErrorMessage = "Informe a marca do carro")]
        public string MarcaCarro { get; set; }
        [Required(ErrorMessage = "Informe o modelo do carro")]
        public string ModeloCarro { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente")]
        public string NameCliente { get; set; }
        [Required(ErrorMessage = "Informe a data de nascimento do cliente")]
        public DateTime DataNascimentoCliente { get; set; }
        [Required(ErrorMessage = "Informe a renda familiar")]
        public decimal RendaFamiliar { get; set; }
        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe a rua")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Informe o nro")]
        public string Nro { get; set; }
        [Required(ErrorMessage = "Informe a cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o uf")]
        public string Uf { get; set; }
        [Required(ErrorMessage = "Informe o sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Informe o telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email Inválido")]
        public string Email { get; set; }
    }
}
