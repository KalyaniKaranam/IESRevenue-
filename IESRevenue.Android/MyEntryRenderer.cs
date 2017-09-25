using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using IESRevenue;
using IESRevenue.Droid;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(MyEntryRenderer))]
namespace IESRevenue.Droid
{
    public class MyEntryRenderer:EntryRenderer
    {
            protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
            {
                base.OnElementChanged(e);

                if (Control != null)
                {
                    Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                }
            }
    }

}