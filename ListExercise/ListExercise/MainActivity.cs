﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace ListExercise
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toListActivityButton = FindViewById<Button>(Resource.Id.listActivityButton);
            var toSecondListActivityButton = FindViewById<Button>(Resource.Id.secondActivityButton);
            var starWarsButton = FindViewById<Button>(Resource.Id.StarWarsButton);

            toListActivityButton.Click += ToListActivityButton_Click;
            toSecondListActivityButton.Click += ToSecondListActivityButton_Click;
            starWarsButton.Click += StarWarsButton_Click;

        }

        private void StarWarsButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(StarWarsListActivity));
            StartActivity(intent);
        }

        private void ToSecondListActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SecondActivity));
            StartActivity(intent);
        }

        private void ToListActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(FirstExampleActivity));
            StartActivity(intent);
        }

      
    }
}