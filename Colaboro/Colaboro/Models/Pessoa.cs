using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class Pessoa
    {
        public object idPessoa { get; set; }
        public string tipo { get; set; } = "fisica";
        public string nome { get; set; }
        public string emailPrincipal { get; set; }
        public string emailAdicional { get; set; }
        public string cpf { get; set; }
        public object rg { get; set; }
        public object dataEmissao { get; set; }
        public object orgaoEmissor { get; set; }
        public object idUfOrgaoEmissor { get; set; }
        public string dataNascimento { get; set; }
        public string sexo { get; set; }
        public List<Telefone> telefones { get; set; }
        public List<Endereco> enderecos { get; set; }
    }
}
