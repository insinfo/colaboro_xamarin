using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Colaboro.Models
{
    [DataContract]//[Preserve(AllMembers = true)]
    public class Usuario
    {
        public Usuario()
        {
        }

        [DataMember(Name = "userName")]
        public string userName { get; set; }
        [DataMember(Name = "password")]
        public string password { get; set; }
    }
}
