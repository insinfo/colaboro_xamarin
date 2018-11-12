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
	public partial class ColaborarPage : ContentPage
	{
        SolicitacaoDataStore storage = null;

        public ColaborarPage()
		{
			InitializeComponent ();
            storage = new SolicitacaoDataStore();
            //listViewSolicitacoes.ItemSelected += ListViewSolicitacoes_ItemSelected;
        }

        /*private void ListViewSolicitacoes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (App.IsLogged())
            {
                listViewSolicitacoes.ItemsSource = await storage.GetItemsAsync();
            }
        }*/
    }
}