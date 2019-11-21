using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Content;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace StarwarsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AppCenter.Start("c6d4036f-1930-4e0a-ac10-ae62f3c7209c",
                   typeof(Analytics), typeof(Crashes));
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            var peopleButton = FindViewById<ImageButton>(Resource.Id.peopleButton);
            var filmsButton = FindViewById<ImageButton>(Resource.Id.filmsButton);

            peopleButton.Click +=  delegate
            {
                Intent intent = new Intent(this, typeof(PeopleActivity));
                StartActivity(intent);
            };

            filmsButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(FilmsActivity));
                StartActivity(intent);
            };
        }
    }
}