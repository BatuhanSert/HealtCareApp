using System;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealtCareApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental" });
            //MainPage = new SharedTransitionNavigationPage(new MainPage());
            MainPage = new SharedTransitionNavigationPage(new LoginPage("", ""))
            {
                BarBackgroundColor = Color.FromHex("636388"),
                BarTextColor = Color.White
            };
            
            //MainPage = new EfeLogin();
            //MainPage = new NavigationPage(new LoginPage("",""));
            //MainPage = new NavigationPage(new WelcomePage("Batuhan"));
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
