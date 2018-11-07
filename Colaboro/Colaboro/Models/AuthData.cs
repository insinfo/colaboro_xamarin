using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colaboro.Models
{
    public class AuthData
    {
        public int expiresIn { get; set; }
        public string accessToken { get; set; }
        public string fullName { get; set; }
        public string loginName { get; set; }
        public int idPessoa { get; set; }
        public int idOrganograma { get; set; }
        public int idPerfil { get; set; }
        public string imagemPessoa { get; set; }
        public string cpfPessoa { get; set; }

        public static AuthData GetFromJson(string json)
        {
            return JsonConvert.DeserializeObject<AuthData>(json);            
        }

        public void FillFromJson(string json)
        {
            AuthData source = JsonConvert.DeserializeObject<AuthData>(json);

            if (source != null)
            {
                var properties = source.GetType().GetProperties();
                foreach (var pi in properties){
                    if (pi.CanRead && pi.CanWrite)
                    pi.SetValue(this, pi.GetValue(source, null), null); 
               }
            }
        }
    }
}
