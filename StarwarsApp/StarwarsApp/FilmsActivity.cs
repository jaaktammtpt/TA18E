using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using StarwarsApp.Core;
using static Android.Widget.AdapterView;

namespace StarwarsApp
{
    [Activity(Label = "FilmsActivity")]
    public class FilmsActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.films_layout);
            // Create your application here
            var films = await DataService.GetStarWarsFilms();
            var filmsListView = FindViewById<ListView>(Resource.Id.filmsListView);
            filmsListView.Adapter = new FilmsAdapter(this, films.Results);

            filmsListView.ItemClick += (object sender, ItemClickEventArgs e) =>
            {               
                var filmDetails = films.Results[e.Position];

                var intent = new Intent(this, typeof(FilmDetailsActivity));
                intent.PutExtra("filmDetails", JsonConvert.SerializeObject(filmDetails));
                StartActivity(intent);
            };
        }
    }
}