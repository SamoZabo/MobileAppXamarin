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

[assembly: ExportRenderer(typeof(Countries.CustomControls.CustomViewCell),
    typeof(Countries.Droid.CustomControls.CustomViewCellRenderer))]
namespace Countries.Droid.CustomControls
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        protected override Android.Views.View GetCellCore(Cell item, Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);
            cell.SetBackgroundColor(Android.Graphics.Color.Rgb(14, 26, 64));
            return cell;
        }
    }
}