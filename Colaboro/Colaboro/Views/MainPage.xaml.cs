using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colaboro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Children.Add(new ServicoPage());
        }
        /*
       protected override void OnAppearing()
       {
          if (!App.IsUserLoggedIn)
           {
               App.NavigationService.NavigateModalAsync(PageNames.LoginPage, false);
           }
           base.OnAppearing();
        }*/


    }
}
