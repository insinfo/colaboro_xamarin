using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Colaboro.Models
{
    [Preserve(AllMembers = true)]
    public class SolicitacaoData
    {
        public int draw { get; set; }
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public int totalPages { get; set; }
        public int page { get; set; }
        public List<Solicitacao> data { get; set; }

        public static SolicitacaoData GetFromJson(string json)
        {
            return JsonConvert.DeserializeObject<SolicitacaoData>(json);
        }
    }
}
