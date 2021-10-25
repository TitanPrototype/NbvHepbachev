using Firebase.Database;
using Firebase.Database.Query;
using NbvHepbachev.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace NbvHepbachev.Services
{
    public class DBFirebase
    {
        FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient("https://nbvhepbachapp-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<Mitglieder> GetMitglieders()
        {
            var mitgliederDaten = client
                .Child("Mitglieder")
                .AsObservable<Mitglieder>()
                .AsObservableCollection();

            return mitgliederDaten;
        }
        public async Task AddMitglied (string vorname, string nachname, string umzug)
        {
            Mitglieder m = new Mitglieder() { Vorname = vorname, Nachname = nachname, Umzug = umzug};
            await client
                .Child("Mitglieder")
                .PostAsync(m);
        }
    }
}
