using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealtCareApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        private void BackTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new SharedTransitionNavigationPage(new MainPage());
            //this.Navigation.PopAsync();
        }
    }
}
