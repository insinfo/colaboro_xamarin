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
    public partial class MainPageDetail : TabbedPage
    {
        public MainPageDetail()
        {
            InitializeComponent();
            this.Children.Add(new ServicoPage());
            this.Children.Add(new ColaboracoesPage());
        }
    }
}