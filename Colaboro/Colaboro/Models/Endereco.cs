using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class Endereco
    {
        public string tipoEndereco { get; set; }
        public string cep { get; set; } = "28895664";
        public int pais { get; set; } = 33;
        public int uf { get; set; } = 20;
        public int municipio { get; set; } = 3242;
        public string tipoLogradouro { get; set; } = "Residencial";
        public string logradouro { get; set; } = "Rua Campo de Albacora";
        public int numeroLogradouro { get; set; } = 75;
        public string bairro { get; set; } = "Atlântica";
        public string complemento { get; set; }
        public bool validacao { get; set; } = true;
        public bool divergente { get; set; } = false;
    }
}
