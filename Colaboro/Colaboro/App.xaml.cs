using Colaboro.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Diagnostics;
using Colaboro.Data;
using System.Threading.Tasks;
using Colaboro.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Colaboro
{         
    public partial class App : Application
    {
        static ColaboroDatabase database;
        public App()
        {
            InitializeComponent();

            /* Resources = new ResourceDictionary();
             Resources.Add("secundary", Color.FromHex("3b4455"));
             Resources.Add("primary", Color.FromHex("FFFFFF"));*/

            //PushModalAsync()
            /* var nav = new NavigationPage(new Views.LoginPage());
             nav.BarBackgroundColor = (Color)App.Current.Resources["secundary"];
             nav.BarTextColor = (Color)App.Current.Resources["primary"];
             MainPage = nav;*/
            AppSettings.Load();           
            if (App.IsLogged())
            {                
                MainPage = new MainPage();
            }
            else
            {              
                MainPage = new LoginPage();
            }
        }
  
       
        public static bool IsLogged()
        {
            if (AppSettings.AuthInfo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ColaboroDatabase Database
        {
            get
            {
                if (database == null)
                {
                    var fileName = "ColabSQLite.db3";
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), fileName);
                   
                    database = new ColaboroDatabase(path);
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    
}
