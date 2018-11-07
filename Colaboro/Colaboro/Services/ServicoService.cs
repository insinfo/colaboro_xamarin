using Colaboro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Colaboro.Services
{
    public class ServicoService
    {
        public static async Task<bool> GetAll(Page context,ListView listView)
        {
            RestClient rest = new RestClient();
            rest.WebserviceURL = AppSettings.WebServiceBaseURL;           
            rest.SetMethodGET();
            rest.ErrorCallbackFunction = (res) => {
                Debug.WriteLine(res);
                Utils.ShowAlert(context, "Não foi possível carregar os serviços");
            };
            rest.SuccessCallbackFunction = (res) => {
                Debug.WriteLine(res);
                listView.ItemsSource = ServicoData.GetFromJson(res).data;

            };
            await rest.Exec(AppSettings.RotaServicos);
            return true;
        }
    }
}
