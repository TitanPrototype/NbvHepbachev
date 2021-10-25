using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbvHepbachev.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NbvHepbachev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartNachLogin : ContentPage
    {
        public StartNachLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MItgliederseite());
        }
    }
}