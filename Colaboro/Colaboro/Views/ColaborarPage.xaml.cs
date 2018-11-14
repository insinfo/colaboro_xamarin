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
        BairroDataStore storage = null;

        public ColaborarPage()
		{
			InitializeComponent ();
            storage = new BairroDataStore(); 
         }

         void OnTapped(object sender, EventArgs e)
         {
            Navigation.PopModalAsync();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            bairroPicker.ItemsSource = storage.GetItems();
        }
    }
}