
using Xamarin.Forms;

namespace IESRevenue
{
    public partial class App : Application
    {
        private string userName;
        private string role;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        

        public App()
        {
            InitializeComponent();
           
            NavigationPage mainPage = new NavigationPage(new IESRevenue.MainPage());
            MainPage = mainPage;           
        }

        protected override void OnStart()
        { 
           
        }

        protected override void OnSleep()
        {
         
        }

        protected override void OnResume()
        {
         
        }
    }
}
