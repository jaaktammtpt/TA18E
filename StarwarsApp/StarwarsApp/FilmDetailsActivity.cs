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

namespace StarwarsApp
{
    [Activity(Label = "FilmDetailsActivity")]
    public class FilmDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.film_details_layout);

            var filmNameTextView = FindViewById<TextView>(Resource.Id.filmTitleTextView);

            var filmDetails = JsonConvert.DeserializeObject<Core.Models.FilmDetails>(Intent.GetStringExtra("filmDetails"));
            filmNameTextView.Text = filmDetails.Title;
        }
    }
}