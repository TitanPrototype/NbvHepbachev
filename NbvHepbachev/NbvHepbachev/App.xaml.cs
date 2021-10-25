using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NbvHepbachev.Views;
using NbvHepbachev;

namespace NbvHepbachev
{
    public partial class App : Application
    {
        public App()

        {
            
            InitializeComponent();

            MainPage = new NavigationPage(new StartNachLogin());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
