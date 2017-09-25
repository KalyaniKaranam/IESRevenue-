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
using Xamarin.Forms.Platform.Android;
using Android.Support.V4.Content;
using IESRevenue.Droid;
using IESRevenue;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(MyPickerRenderer))]
namespace IESRevenue.Droid
{
    public class MyPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Picker> e)
        {
            base.OnElementChanged(e);
            var button = e.NewElement;

            if (this.Control != null)
            {
                //this.Control.SetBackgroundResource(Resource.Drawable.styledropdown);
            }           
        }

        //private void picker_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
        //Spinner mySpinner;
        // Override the OnModelChanged method so we can tweak this renderer post-initial setup
        //protected override void OnModelChanged(VisualElement oldModel, VisualElement newModel)
        //{
        //    base.OnModelChanged(oldModel, newModel);

        //    // lets get a reference to the native control
        //    var nativeEditText = (TextView)Control;
        //    // do whatever you want to the EditText here!
        //    mySpinner = new Spinner(this.Context);
        //    nativeEditText.SetBackgroundColor(global::Android.Graphics.Color.Yellow);
        //    mySpinner.SetBackgroundResource(CustomRenderer.Android.Resource.Drawable.spinner_border);
        //    this.SetNativeControl(mySpinner);
        //}
    }
}

      
      