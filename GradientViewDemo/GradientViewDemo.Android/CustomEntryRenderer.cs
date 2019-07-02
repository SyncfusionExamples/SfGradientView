using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientViewDemo.Views.CustomEntry), typeof(GradientViewDemo.Droid.CustomEntryRenderer))]
namespace GradientViewDemo.Droid
{
    public class CustomEntryRenderer : EntryRenderer 
    {
        public CustomEntryRenderer() : base(Android.App.Application.Context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
            }
        }

    }
}