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
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(Countries.CustomControls.CustomViewList),
    typeof(Countries.Droid.CustomControls.CustomListViewRenderer))]
namespace Countries.Droid.CustomControls
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Divider = new ColorDrawable(Android.Graphics.Color.Rgb(34, 47, 91));
                Control.DividerHeight = 8;
            }
                
        }
    }
}