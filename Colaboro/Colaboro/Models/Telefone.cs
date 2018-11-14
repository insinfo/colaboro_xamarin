using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Colaboro.Models
{
    [Preserve(AllMembers = true)]
    public class Telefone
    {
        public string tipoTelefone { get; set; } = "Móvel";
        public string numeroTelefone { get; set; }
    }
}
