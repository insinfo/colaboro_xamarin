using Colaboro.Models;
using Colaboro.Services;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Colaboro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            btnCadastrar.Clicked += BtnCadastrar_Clicked;
            btnEntrar.Clicked += BtnEntrar_Clicked;
        }

        private async void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CadastroPage());
        }        

        private async void BtnEntrar_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text))
            {
                Utils.ShowAlert(this, "Digite o nome de usuário!");
                usernameEntry.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                Utils.ShowAlert(this, "Digite a senha!");
                passwordEntry.Focus();
                return;
            }

           await AuthService.AtenticarUsuario(this, usernameEntry.Text, passwordEntry.Text);
        }
        /*
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        */

    }
}