using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class Solicitacao
    {
        public int id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public int ano { get; set; }
        public int idOrganograma { get; set; }
        public int idSolicitante { get; set; }
        public object idSolicitantesec { get; set; }
        public object idEquipamento { get; set; }
        public int idOperador { get; set; }
        public string descricao { get; set; }
        public string observacao { get; set; }
        public string dataAbertura { get; set; }
        public string dataFechamento { get; set; }
        public int prioridade { get; set; }
        public int atendimentoIni { get; set; }
        public int totalAtendimentos { get; set; }
        public int minStatus { get; set; }
        public string statusAtendimentos { get; set; }
        public string setorResponsavelSigla { get; set; }
        public string setorResponsavelNome { get; set; }
        public string siglaOrganograma { get; set; }
        public string nomeOrganograma { get; set; }
        public string nomeSolicitante { get; set; }
        public string cpfSolicitante { get; set; }
        public string historicoAtendimento { get; set; }
        public string idsAtendimento { get; set; }
        public string usuariosEnvolvidosAtendimento { get; set; }
        public string pessoasEnvolvidasHistorico { get; set; }
        public string idsUsuario { get; set; }
        public string idsSetorResponsavel { get; set; }
    }
}
