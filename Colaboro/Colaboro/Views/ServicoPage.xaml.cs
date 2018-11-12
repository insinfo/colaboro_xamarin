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
		public ServicoPage ()
		{
			InitializeComponent();
            listViewServicos.ItemSelected += ListViewServicos_ItemSelected;

        }

        private void ListViewServicos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Servico;


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (App.IsLogged())
            {
                await ServicoService.GetAll(this, listViewServicos);
            }
        }
    }
}