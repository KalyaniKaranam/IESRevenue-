
using Android.App;
using Android.Content.PM;
using Android.Views;
//using Android.OS;
//using OxyPlot.Xamarin.Forms.Platform.Android;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using System.Threading.Tasks;
using Java.Lang;
using System;
using Java.IO;
using Android.Content;
using Xamarin.Forms;
using OxyPlot.Xamarin.Forms.Platform.Android;
using Android.OS;
using IESRevenue.Model;

namespace IESRevenue.Droid
{
    [Activity(Label = "IESRevenue", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, WindowSoftInputMode = SoftInput.AdjustResize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

     }

       
    }
       
        }

