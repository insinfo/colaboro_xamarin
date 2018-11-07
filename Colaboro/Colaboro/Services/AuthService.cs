using Acr.UserDialogs;
using Colaboro.Models;
using Colaboro.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;

namespace Colaboro.Services
{
    public class AuthService
    {      

        public static async Task<bool> AtenticarUsuario(Page context,string user, string pass)
        {
            //await this.Navigation.PushModalAsync(new MainPage());

            //var dialog = UserDialogs.Instance;//.Loading("Carregando...",null,null,false);
            //dialog.ShowLoading();                     

            RestClient rest = new RestClient();
            rest.WebserviceURL = AppSettings.WebServiceBaseURL;
            rest.DataToSender = new { userName = user, password = pass };
            rest.SetMethodPOST();
            rest.ErrorCallbackFunction = (res) => {
                Debug.WriteLine(res);
                Utils.ShowAlert(context, "Não foi possível autenticar");
            };
            rest.SuccessCallbackFunction = (res) => {               
                Debug.WriteLine(res);
                AppSettings.AuthInfo = AuthData.GetFromJson(res);
                AppSettings.Save();
                context.Navigation.PushModalAsync(new MainPage());
            };
            await rest.Exec(AppSettings.RotaLogin);
            // dialog.HideLoading();
            //dialog.Alert(resp);*/

            //

            /*

                 const string KEY = "7Fsxc2A865V67"; // chave

                 var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpYXQiOjE1NDA5NTA4NjcsImlzcyI6Imp1YmFydGUucmlvZGFzb3N0cmFzLnJqLmdvdi5iciIsImV4cCI6MTU0MDk4MzI2NywibmJmIjoxNTQwOTUwODY2LCJkYXRhIjp7ImlkU2lzdGVtYSI6MSwiaWRQZXNzb2EiOjIsImlkT3JnYW5vZ3JhbWEiOjE5LCJsb2dpbk5hbWUiOiJpc2FxdWUubmV2ZXMiLCJpZFBlcmZpbCI6MiwicHdzIjoiM3FjWWRSWFZEblJBR25sUXZ2UUZDSEpSXC9ub1B3bzRDbVE9PSIsImlwQ2xpZW50UHJpdmF0ZSI6IjEwLjAuMC40IiwiaXBDbGllbnRQdWJsaWMiOiIxNzcuMTMwLjguOTAiLCJpcENsaWVudFZpc2libGVCeVNlcnZlciI6IjE5Mi4xNjguNjYuMjkiLCJob3N0IjoicHJvZHVjYW8ucmlvZGFzb3N0cmFzLnJqLmdvdi5iciIsIm9yaWdpbiI6Imh0dHA6XC9cL3Byb2R1Y2FvLnJpb2Rhc29zdHJhcy5yai5nb3YuYnIiLCJjcGZQZXNzb2EiOiIxMzEyODI1MDczMSIsInVzZXJBZ2VudCI6Ik1vemlsbGFcLzUuMCAoV2luZG93cyBOVCAxMC4wOyBXaW42NDsgeDY0KSBBcHBsZVdlYktpdFwvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lXC82OS4wLjM0OTcuMTAwIFNhZmFyaVwvNTM3LjM2In19.JcCmEYNzXeUZNqsWFlWXEupdDYeXazjzXlZmltHZAW8";
                 var json = new JwtBuilder()
                     .WithSecret(KEY)
                     .MustVerifySignature().WithAlgorithm(new HMACSHA256Algorithm())
                     .Decode(token);

                
             }
             catch (TokenExpiredException)
             {                
                 ShowAlert("Token has expired");
             }
             catch (SignatureVerificationException)
             {               
                 ShowAlert("Token has invalid signature");
             }*/

            return true;
        }

        /*
        private static Token Login(string username, string password)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(WebServiceURL);
            HttpResponseMessage response =
              client.PostAsync("Token",
                new StringContent(string.Format("grant_type=password&username={0}&password={1}",
                  HttpUtility.UrlEncode(username),
                  HttpUtility.UrlEncode(password)), Encoding.UTF8,
                  "application/x-www-form-urlencoded")).Result;
            string resultJSON = response.Content.ReadAsStringAsync().Result;
            Token result = JsonConvert.DeserializeObject<Token>(resultJSON);
            return result;
        }

        private async void retornoJsonAsync(string token, string baseUrl)
        {
            bool validar = false;
            ModeloCliente cliente = new ModeloCliente();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://clienteapi.azurewebsites.net/");

            client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

            HttpResponseMessage response = await client.GetAsync("api/Cliente");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonString, (typeof(DataTable)));
                validar = true;
            }
        }*/
    }
}
