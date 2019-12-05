using Android.App;
using Android.OS;
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
        // Test1
        // Test2
    }
}