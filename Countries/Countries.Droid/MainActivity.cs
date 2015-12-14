using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin;
using System.Collections.Generic;

namespace Countries.Droid
{
    [Activity(Label = "Countries", Icon = "@drawable/Weather_icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            string userId = "a8cf0d883ec46e44c20690a6ec5c6d9628742708";
            Insights.HasPendingCrashReport += (sender, isStartupCrash)=>
            {
                if (isStartupCrash)
                {
                    Insights.PurgePendingCrashReports().Wait();
                }
            };

            Insights.Initialize(userId, Application.ApplicationContext);
            Insights.ForceDataTransmission = true;
            Dictionary<string, string> userValues = new Dictionary<string, string>
            {
                {Insights.Traits.Name,"Islam" },
                {Insights.Traits.LastName,"Al-Zobaydee" },
                {Insights.Traits.Email,"islam.alzobaydee@hotmail.com" }
            };
            Insights.Identify(userId, userValues);
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

