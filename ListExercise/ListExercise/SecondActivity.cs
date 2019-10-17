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

namespace ListExercise
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {

        List<WeatherInfo> _items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.second_layout);

            _items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name = "Eeeeeeeeeeeeeeeeeeeeeeeeeeeeeesmaspäev",Temperature = "12c",WindSpeed = "4m/s" },
                new WeatherInfo(){Name = "Teisipäev",Temperature = "11c",WindSpeed = "2m/s" },
                new WeatherInfo(){Name = "Kolmapäev",Temperature = "9c",WindSpeed = "6m/s" },
                new WeatherInfo(){Name = "Neljapäev",Temperature = "12c",WindSpeed = "4m/s" },
                new WeatherInfo(){Name = "Reede",Temperature = "4c",WindSpeed = "2m/s" },
                new WeatherInfo(){Name = "Laupäev",Temperature = "2c",WindSpeed = "3m/s" },
                new WeatherInfo(){Name = "Pühapäev",Temperature = "15c",WindSpeed = "6m/s" }
            };

            var listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new BasicAdapter(this, _items);

        }
    }
}