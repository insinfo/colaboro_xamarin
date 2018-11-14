using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Xamarin.Forms.Internals;

namespace Colaboro.Models
{
    [Preserve(AllMembers = true)]
    public class Servico
    {
        public int id { get; set; }
        public object icone { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int idSetor { get; set; }
        public string cor { get; set; }
    }
}
