using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NbvHepbachev.Views;

namespace NbvHepbachev
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MItgliederseite();
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
