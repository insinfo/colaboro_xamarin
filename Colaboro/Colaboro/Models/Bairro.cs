using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class Bairro
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCity { get; set; }
        public override string ToString()
        {
            return nome;
        }
    }
}
