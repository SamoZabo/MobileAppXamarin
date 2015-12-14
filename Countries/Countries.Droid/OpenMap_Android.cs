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
using Countries.Interface;
using Xamarin.Forms;
using Countries.Droid;
using Xamarin;
using Android.Content.PM;

[assembly:Dependency(typeof(OpenMap_Android))]
namespace Countries.Droid
{
    [Activity(Label = "Countries", Icon = "@drawable/Weather_icon", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class OpenMap_Android : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, IOpenMap
    {
        public OpenMap_Android()
        {

        }
        public void OpenMap(double lat, double lon)
        {
            var geoUri = Android.Net.Uri.Parse("http://www.latlong.net/c/?lat="+lat+"&long="+lon);
            var mapIntent = new Intent(Intent.ActionView, geoUri);
            try
            {
               
                Forms.Context.StartActivity(mapIntent);
                // StartActivity(typeof(OpenMap_Android));
                //StartActivity(mapIntent);
            }
            catch (Exception ex)
            {
                Insights.Report(ex, new Dictionary<string, string>() { { "OpenMap", "Android" } }, Insights.Severity.Error);
                
            }
            
        }
    }
}