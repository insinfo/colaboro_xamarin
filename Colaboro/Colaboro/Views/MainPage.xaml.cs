using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colaboro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();            
        }

       protected override bool OnBackButtonPressed()
       {
            if (App.IsLogged())
            {
                App.Current.Quit();
                return true;
            }
           return false;
       }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainPageMenuItem;

            if (item != null)
            {
                if (item.CallBack != null)
                {
                    item.CallBack();
                }
            }

            if (item == null)
            {                
                return;
            }
            try
            {
                Debug.WriteLine(item.TargetType.ToString());
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;

                //Detail = new NavigationPage(page);
                // IsPresented = false;
                Navigation.PushModalAsync(page);

                MasterPage.ListView.SelectedItem = null;

            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}