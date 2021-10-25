using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmHelpers.Commands;
using NbvHepbachev.Services;
using NbvHepbachev.Models;
using System.Threading.Tasks;
using MvvmHelpers;

namespace NbvHepbachev.ViewModels
{
    public class MitgliederViewModel : BaseViewModel
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Umzug { get; set; }

        private DBFirebase services;

        public Command AddMitgliederCommand { get; }

        private ObservableCollection<Mitglieder> _mitglieder = new ObservableCollection<Mitglieder>();
        public ObservableCollection<Mitglieder> Mitglieders
        {
            get { return _mitglieder; }
            set
            {
                _mitglieder = value;
                OnPropertyChanged();
            }
        }

        public MitgliederViewModel()
        {
            services = new DBFirebase();
            Mitglieders = services.GetMitglieders();
            AddMitgliederCommand = new Command(async () => await AddMitgliederAsync(Vorname, Nachname, Umzug));
        }

        public async Task AddMitgliederAsync ( string Vorname , string Nachname , string Umzug)
        {
            await services.AddMitglied(Vorname, Nachname, Umzug);
        }
    }
}
