using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Countries.CustomControls
{
    public class CustomViewCell : ViewCell
    {
        protected override void OnBindingContextChanged()
        {
            //View.BindingContext = BindingContext;
            base.OnBindingContextChanged();
        }
    }
}
