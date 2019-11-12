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
using StarwarsApp.Core;

namespace StarwarsApp
{
    [Activity(Label = "PeopleActivity")]
    public class PeopleActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.people_layout);

            var data = await DataService.GetStarWarsPeople("https://swapi.co/api/people/");
        }
    }
}