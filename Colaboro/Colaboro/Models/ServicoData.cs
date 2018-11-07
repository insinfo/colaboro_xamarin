using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class ServicoData
    {
        public int draw { get; set; }
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public int totalPages { get; set; }
        public int page { get; set; }
        public List<Servico> data { get; set; }

        public static ServicoData GetFromJson(string json)
        {
            return JsonConvert.DeserializeObject<ServicoData>(json);
        }
    }
}
