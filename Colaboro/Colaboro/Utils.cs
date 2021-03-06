using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Colaboro
{
    public class Utils
    {
        public static async void ShowAlert(Page context, string mensagem)
        {
            await context.DisplayAlert("Atenção", mensagem, "Ok");
        }

        public static string ToJson(object obj)
        {
           return  JsonConvert.SerializeObject(obj);
        }

       
    }
}
