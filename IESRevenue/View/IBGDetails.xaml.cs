using IESRevenue.Helper;
using IESRevenue.ViewModel;
using OxyPlot;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IESRevenue.View
{
    public partial class IBGDetails : ContentPage
    {
        SBUPageViewModel sbuViewModel = new SBUPageViewModel();
        ShowGraphViewModel showGraphVM = new ShowGraphViewModel();

        public string ibGName;
        public string tabName;
        public string strRole;
        public string pageinfo;
        public List<string> ibuList;
        public List<object> pIDList;
        public string role;

        public IBGDetails(Enums.Enums.RoleEnum role, string tabName)
        {
            InitializeComponent();

            Title = tabName;
            strRole = role.ToString();
            pageinfo = tabName;
            GenerateUI();
        }

        private void GenerateUI()
        {
            PIDPicker.IsVisible = false;
            if (Application.Current.Properties.ContainsKey("FunctionalUnitName"))
                ibGName = Application.Current.Properties["FunctionalUnitName"].ToString();
            if (pageinfo == "IBGPage")
            {
                IBUPicker.Title = "Select Project";
                PIDPicker.IsVisible = false;
                LoadPIDPicker(ibGName);
            }
            else
                LoadIBUPicker(ibGName);
        }

        private async void LoadPIDPicker(string ibGName)
        {
            if (pIDList == null)
            {
                var pIDResponse = await sbuViewModel.GetPid(ibGName);
                if (pIDResponse != null)
                    pIDList = pIDResponse.MESSAGE.PAYLOAD.GET_PIDS.PIDS;
            }

            if (pIDList != null)
            {
                IBUPicker.Items.Clear();

                foreach (var pID in pIDList)
                {
                    IBUPicker.Items.Add(pID.ToString());
                }

                IBUPicker.Items.Add("ALL");
            }
        }

        private async void LoadIBUPicker(string ibgID)
        {
            if (ibuList == null)
            {
                var ibuResponse = await sbuViewModel.GetIbuId(ibgID);
                ibuList = ibuResponse.MESSAGE.PAYLOAD.GET_IBUIDS.IBU_ID;
            }

            IBUPicker.Items.Clear();

            foreach (var ibu in ibuList)
            {
                IBUPicker.Items.Add(ibu);
            }
            IBUPicker.Items.Add("ALL");

            if (Title == "IBU" || strRole == "IBU")
            {
                PIDPicker.IsVisible = true;
                PIDPicker.IsEnabled = true;
                IBUPicker.SelectedIndexChanged += IbuPicker_SelectedIndexChanged;
            }
        }


        private async void OnPickerClicked(object sender, EventArgs e)
        {
            PickerListFilter pickerListPage = new PickerListFilter();
            //pickerListPage.pickerHandler += (pickersender, pickerargs) =>
            //{

            //};
        }

        private void HandleTextPickerAction(object sender, PickerActionEventArgs e)
        {
            //SetClosureDataElement(e.activityClosureField.FieldId, e.pickerValue);
        }

        private void SetClosureDataElement(int fieldId, object value)
        {
            //for (int i = 0; i < _internalClosureData.Length; i++)
            //{
            //    // Check the value is already entered to the corresponding Field ID
            //    if (_internalClosureData[i].FieldId == fieldId)
            //    {
            //        _dataEntered = true;
            //        _internalClosureData[i].Value = value;
            //        break;
            //    }
            //}
        }

        private void PrepareTaskClosureData()
        {
            //string key = GetProgressKey(taskId, activityTask.JobStatus);

            //// always start at activity 0 for CICs
            //if (key.Contains(ClientConstants.cicPrefix))
            //{
            //    _activityClosureProgress = new ActivityClosureProgress()
            //    {
            //        CurrentActivityIndex = 0,
            //        ClosureJobStatus = activityTask.JobStatus
            //    };
            //}
            //else
            //{
            //    // get existing closure progress
            //    if (!ClosureProgress.ContainsKey(key))
            //    {
            //        ClosureProgress[key] = new ActivityClosureProgress()
            //        {
            //            CurrentActivityIndex = 0,
            //            ClosureJobStatus = activityTask.JobStatus
            //        };

            //        WriteClosureProgress();
            //    }

            //    _activityClosureProgress = ClosureProgress[key];

            //    // if server reckons current activity is further on than client record, catch up with server
            //    if (serverAcp != null)
            //    {
            //        // only catch up if closing as complete
            //        if (_activityClosureProgress.ClosureJobStatus == serverAcp.ClosureJobStatus
            //            && serverAcp.ClosureJobStatus == ClientConstants.jobStatusComplete)
            //        {
            //            if (serverAcp.CurrentActivityIndex > _activityClosureProgress.CurrentActivityIndex)
            //            {
            //                _activityClosureProgress.CurrentActivityIndex = serverAcp.CurrentActivityIndex;
            //            }
            //        }
            //    }
            //}
        }


        private async void IbuPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IBUPicker.SelectedIndex == -1)
                await DisplayAlert("Alert", "Please Select", "OK");
            else
            {
                var selectedIBUValue = IBUPicker.SelectedItem;

                if (pIDList == null)
                {
                    var pIDResponse = await sbuViewModel.GetPid(selectedIBUValue.ToString());
                    if (pIDResponse != null)
                        pIDList = pIDResponse.MESSAGE.PAYLOAD.GET_PIDS.PIDS;
                }

                PIDPicker.Items.Clear();

                foreach (var pID in pIDList)
                {
                    PIDPicker.Items.Add(pID.ToString());
                }

                PIDPicker.Items.Add("ALL");
            }
        }

        private async void OnMoreGraphsClicked(object sender, EventArgs e)
        {
            var revenueCollection = showGraphVM.monthVsRevenueCollection;
            var ebitaCollection = showGraphVM.monthVsEBITACollection;
            var monthList = showGraphVM.monthList;

            await Navigation.PushAsync(new ShowMoreGraphs(revenueCollection, ebitaCollection, monthList));
        }

        private async void OnGenerateGraphClicked(object sender, EventArgs e)
        {
            if (IBUPicker.SelectedIndex == -1 || YearPicker.SelectedIndex == -1 || QuarterPicker.SelectedIndex == -1)
            {
                await DisplayAlert("Alert", "Please select the options from dropdown", "OK");
            }

            else
            {
                if (Title == "IBG" || strRole == "IBG")
                {
                    PlotModel plotModel = await showGraphVM.GetIBURevenueAndEbita(ibGName, IBUPicker.SelectedItem.ToString(),
                     DateManipulation.DeriveStartDatesFromYearAndQuarter(YearPicker.SelectedItem.ToString(), QuarterPicker.SelectedItem.ToString()));

                    graph.Model = plotModel;
                    graph.IsVisible = true;

                }
                else if (Title == "IBU" || strRole == "IBU")
                {
                    if (pageinfo != "IBGPage" && PIDPicker.SelectedIndex == -1)
                        await DisplayAlert("Alert", "Please select the options from dropdown", "OK");
                    string pickerValue = pageinfo == "IBGPage" ? IBUPicker.SelectedItem.ToString() : PIDPicker.SelectedItem.ToString();
                    PlotModel plotModel = await showGraphVM.GetPIDRevenueAndEbita(IBUPicker.SelectedItem.ToString(), pickerValue,
                     DateManipulation.DeriveStartDatesFromYearAndQuarter(YearPicker.SelectedItem.ToString(), QuarterPicker.SelectedItem.ToString()));

                    graph.Model = plotModel;
                    graph.IsVisible = true;
                }
            }
            btnMoreGraphs.IsEnabled = true;
        }

        public class PickerActionEventArgs : EventArgs
        {
            /// <summary>
            /// Gets or sets the activity closure field.
            /// </summary>
            /// <value>
            /// The activity closure field.
            /// </value>
            public List<string> activityClosureField { get; set; }
            /// <summary>
            /// Gets or sets the picker value.
            /// </summary>
            /// <value>
            /// The picker value.
            /// </value>
            public string pickerValue { get; set; }
            /// <summary>
            /// Gets or sets the name of the picker.
            /// </summary>
            /// <value>
            /// The name of the picker.
            /// </value>
            public string pickerName { get; set; }
            /// <summary>
            /// Initializes a new instance of the <see cref="PickerActionEventArgs"/> class.
            /// </summary>
            /// <param name="closureField">The closure field.</param>
            /// <param name="pickervalue">The pickervalue.</param>
            /// <param name="pickername">The pickername.</param>
            public PickerActionEventArgs(List<string> closureField, string pickervalue, string pickername)
            {
                activityClosureField = closureField;
                pickerValue = pickervalue;
                pickerName = pickername;
            }


        }

    }
}
