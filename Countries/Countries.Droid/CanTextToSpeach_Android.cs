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
using Xamarin.Forms;
using Countries.Droid;
using Countries.Interface;
using Plugin.TextToSpeech;

[assembly: Dependency(typeof(CanTextToSpeach_Android))]
namespace Countries.Droid
{
    public class CanTextToSpeach_Android : ICanTextToSpeach
    {
        public void Say(string text)
        {
            CrossTextToSpeech.Current.Speak(text);
        }
    }
}