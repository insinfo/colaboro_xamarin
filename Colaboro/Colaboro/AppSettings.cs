using Colaboro.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace Colaboro
{
    public class AppSettings
    {
        public const string WebServiceBaseURL = "https://jubarte.riodasostras.rj.gov.br";
        public const string RotaLogin = "/api/app/auth/login";
        public const string RotaServicos = "/ciente/api/app/servicos";

        public static AuthData AuthInfo { get; set; } 
        public static void Load()
        {
            if (Application.Current.Properties.ContainsKey("info"))
            {              
                var json = (string) Application.Current.Properties["info"];
                AuthInfo = JsonConvert.DeserializeObject<AuthData> (json);               
            }
        }
        public static void Save()
        {
            if (AuthInfo != null)
            {
                var info = JsonConvert.SerializeObject(AuthInfo);
                Application.Current.Properties["info"] = info;
            }
        }

        public static void Clear()
        {
            AuthInfo = null;
            Application.Current.Properties.Clear();
        }
    }
}
