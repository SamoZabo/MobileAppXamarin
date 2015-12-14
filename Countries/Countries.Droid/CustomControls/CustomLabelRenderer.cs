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
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Countries.CustomControls.CustomLabel),
    typeof(Countries.Droid.CustomControls.CustomLabelRenderer))]
namespace Countries.Droid.CustomControls
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control?.SetTextColor(Android.Graphics.Color.Rgb(235, 242, 6));
        }
    }
}