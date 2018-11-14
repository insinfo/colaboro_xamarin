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
using System.ComponentModel;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Colaboro.ColabControls;
using Colaboro.Droid.Renderers;

[assembly: ExportRenderer(typeof(CircleView), typeof(CircleViewRenderer))]
namespace Colaboro.Droid.Renderers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class CircleViewRenderer : BoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            SetWillNotDraw(false);
            Invalidate();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CircleView.CornerRadiusProperty.PropertyName)
            {
                Invalidate();
            }
        }

        public override void Draw(Canvas canvas)
        {
            var box = Element as CircleView;
            var rect = new Rect();
            var paint = new Paint()
            {
                Color = box.BackgroundColor.ToAndroid(),
                AntiAlias = true,
            };
            GetDrawingRect(rect);
            var radius = (float)(rect.Width() / 14 * 7); // ... / box width * box corner radius
            canvas.DrawRoundRect(new RectF(rect), radius, radius, paint);
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}