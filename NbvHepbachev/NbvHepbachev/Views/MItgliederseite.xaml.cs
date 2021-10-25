using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbvHepbachev.Models;
using NbvHepbachev.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NbvHepbachev.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MItgliederseite : ContentPage
    {
        public MItgliederseite()
        {
            InitializeComponent();

            BindingContext = new MitgliederViewModel();
            
            
        }
    }
}