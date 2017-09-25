using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IESRevenue.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraphRepresentation : ContentPage
    {
        int a;
        public GraphRepresentation()
        {
            InitializeComponent();
            if (graphFilter.SelectedIndex == -1)
            {
                a = -1;
                BindingContext = new ViewModel.GraphRepresentationViewModel(a);
            }
        }
        private async void onItemSelect(object sender, EventArgs e)
        {
            var picker = sender as Picker;
            if (picker.SelectedIndex == -1)
            {
                await DisplayAlert("Alert", "Please Select", "OK");
            }
            else
            {
                a = picker.SelectedIndex;
                BindingContext = new ViewModel.GraphRepresentationViewModel(a);
                //var selectedPidItem1 = pid.SelectedItem;
                //SelectedPid1 = selectedPidItem1.ToString();
            }
        }
    }
}
