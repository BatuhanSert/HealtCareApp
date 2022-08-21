using System;
using CoreGraphics;
using HealtCareApp;
using HealtCareApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererIos))]
namespace HealtCareApp.iOS
{
    public class RoundedEntryRendererIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)
            {
                Control.Layer.CornerRadius = 30;
                Control.Layer.BorderWidth  = 2;
                Control.Layer.BorderColor = Color.FromHex("#e6e6e6").ToCGColor();
                Control.Layer.BackgroundColor = Color.White.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 30, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}
