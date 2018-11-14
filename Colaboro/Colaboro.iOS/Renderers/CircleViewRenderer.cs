using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colaboro.ColabControls;
using Colaboro.iOS.Renderers;
using Foundation;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CircleView), typeof(CircleViewRenderer))]
namespace Colaboro.iOS.Renderers
{
    public class CircleViewRenderer : BoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            if (Element != null)
            {
                Layer.MasksToBounds = true;
                UpdateCornerRadius(Element as CircleView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CircleView.CornerRadiusProperty.PropertyName)
            {
                UpdateCornerRadius(Element as CircleView);
            }
        }

        void UpdateCornerRadius(CircleView box)
        {
            Layer.CornerRadius = 7;  
            box.WidthRequest = 14;
            box.HeightRequest = 14;
        }
    }
}