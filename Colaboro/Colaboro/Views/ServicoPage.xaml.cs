using Colaboro.Models;
using Colaboro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colaboro.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ServicoPage : ContentPage
	{
        private ServicoDataStore storage;
		public ServicoPage ()
		{
			InitializeComponent();
            listViewServicos.ItemSelected += ListViewServicos_ItemSelectedAsync;
            storage = new ServicoDataStore();
        }

        private async void ListViewServicos_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Servico;
            await Navigation.PushModalAsync(new ColaborarPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (App.IsLogged())
            {
                try
                {
                    listViewServicos.ItemsSource = await storage.GetItemsAsync();

                }catch(Exception ex)
                {
                    Utils.ShowAlert(this, StatusMessage.ErroPadrao);
                }
            }
        }
    }
}