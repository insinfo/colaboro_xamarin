using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colaboro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }
        public ListView ListView = null;

        public MainPageMaster()
        {
            InitializeComponent();      
            
            MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {               
                new MainPageMenuItem { Id = 1, Title = "Politicas",TargetType=typeof(PoliticaPage)},
                new MainPageMenuItem { Id = 2, Title = "Sobre",TargetType=typeof(SobrePage)},
                new MainPageMenuItem { Id = 3, Title = "Sair",CallBack = async () => {
                    AppSettings.Clear();                    
                    await Navigation.PushModalAsync(new LoginPage());                   
                    return true;
                }
            }
            });

            ListView = MenuItemsListView;
            ListView.ItemsSource = MenuItems;
        }

        
    }
}