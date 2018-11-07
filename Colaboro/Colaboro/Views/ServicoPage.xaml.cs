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
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ServicoService.GetAll(this, listViewServicos);
        }
    }
}