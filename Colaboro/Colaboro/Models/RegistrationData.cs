using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Colaboro.Models
{
    [Preserve(AllMembers = true)]
    public class RegistrationData
    {
        public Pessoa pessoa { get; set; }
        public Usuario usuario { get; set; }
    }
}
