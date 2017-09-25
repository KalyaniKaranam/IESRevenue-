//using Android.Widget;
//using IESRevenue.Droid.Custom_Renderer;
//using System;
//using System.Collections.Generic;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Picker), typeof(CustomPickerRenderer))]
//namespace IESRevenue.Droid.Custom_Renderer
//{
//    public class CustomPickerRenderer : ViewRenderer<Picker, Spinner>
//    {
//        Picker picker;
//        Spinner spinner;

//        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
//        {
//            base.OnElementChanged(e);
//            //if (e.OldElement != null || Element == null)
//            //{
//            //return;
//            //}
//            picker = e.NewElement;
//            IList<string> scaleNames = e.NewElement.Items;
//            spinner = new Spinner(this.Context);

//            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

//            var scaleAdapter = new ArrayAdapter<string>(this.Context, Android.Resource.Layout.SimpleSpinnerItem, scaleNames);

//            scaleAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

//            spinner.Adapter = scaleAdapter;

//            base.SetNativeControl(spinner);
//        }

//        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
//        {
//            picker.SelectedIndex = (e.Position);
//        }
//    }
//}