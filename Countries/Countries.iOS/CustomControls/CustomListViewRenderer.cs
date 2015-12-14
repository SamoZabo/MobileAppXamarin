using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(Countries.CustomControls.CustomViewList), 
    typeof(Countries.iOS.CustomControls.CustomListViewRenderer))]
namespace Countries.iOS.CustomControls
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            if(Control !=null)
            Control.SeparatorColor = UIKit.UIColor.Red;
        }
    }
}
