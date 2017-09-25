using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IESRevenue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IBGPage : ContentPage
    {
        DateTime fromibgdat, toibgdat;
        string fromibgDate, toibgDate;
        public IBGPage()
        {
            InitializeComponent();          
        }
        private void OnIBGFromDateSelected(object sender, DateChangedEventArgs e)
        {
            fromibgdat = new DateTime(fromibgdate.Date.Year, fromibgdate.Date.Month, 01);
            fromibgDate = fromibgdat.ToString("yyyy-MM-dd");
        }

        private void OnIBGToDateSelected(object sender, DateChangedEventArgs e)
        {
            toibgdat = new DateTime(toibgdate.Date.Year, toibgdate.Date.Month, 01);
            toibgDate = toibgdat.ToString("yyyy-MM-dd");
        }
    }
}
