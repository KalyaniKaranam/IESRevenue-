using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IESRevenue.View
{
    public partial class GenericListSelectorPage : ContentPage, IBindingContextView
    {
        private string[] _options;
        public string[] Options
        {
            get { return _options; }
            set { _options = value; }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private Action<string> _returnCommand;
        private string LastSelected;

        public GenericListSelectorPage()
        {
            InitializeComponent();
        }

        public void ChangeContext(params object[] args)
        {
            if (args.Length != 3)
                return;

            Title = args[0] as string;
            //GetArgValue(args, 0, typeof(string)) as string;
            var options = args[1] as List<string>;
            _returnCommand =args[3] as Action<string>;

            if (options != null)
            {
                ItemListView.ItemsSource = SingleItemMenuSelectable.StringArrayToObservableCollection(options);
            }

            BindingContext = this;
        }
               

        public static object GetArgValue(object[] args, int index, Type typeToReturn, bool acceptNull = false)
        {
            if (args.Length <= index && !acceptNull)
                throw new InvalidArgsCountException(args, index + 1);

            if (args.Length <= index && acceptNull)
                return null;

            var item = args[index];
            if (item == null && !acceptNull)
                return null;

            if (item == null || item.GetType().FullName == typeToReturn.FullName)
                return item;

            //get inmplemented interfaces
            var itemInterfaceTypes = item.GetType().GetTypeInfo().ImplementedInterfaces.ToList();
            if (itemInterfaceTypes != null)
            {
                if (itemInterfaceTypes.Find(x => x.FullName == typeToReturn.FullName) != null)
                    return item;
            }

            //Test if is sub type..
            var itemType = item.GetType();
            while (itemType != null)
            {
                if (itemType.FullName == typeToReturn.FullName)
                    return item;

                itemType = itemType.GetTypeInfo().BaseType;
            }
            return null;
        }

        protected void OnDismiss(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void OnListItemTapped(object sender, ItemTappedEventArgs e)
        {
            LastSelected = ((SingleItemMenuSelectable)e.Item).SelectableString;
            _returnCommand?.Invoke(LastSelected);
            ((ListView)sender).SelectedItem = null;
            Navigation.PopModalAsync();
        }
    }

    public class SingleItemMenuSelectable
    {
        private string _selectableString;
        public string SelectableString
        {
            get { return _selectableString; }
            set { _selectableString = value; }
        }

        public SingleItemMenuSelectable(string dataString)
        {
            SelectableString = dataString;
        }

        public static ObservableCollection<SingleItemMenuSelectable> StringArrayToObservableCollection(List<string> selections)
        {
            ObservableCollection<SingleItemMenuSelectable> collection = new ObservableCollection<SingleItemMenuSelectable>();
            foreach (string s in selections)
            {
                collection.Add(new SingleItemMenuSelectable(s));
            }

            return collection;
        }
    }
}

