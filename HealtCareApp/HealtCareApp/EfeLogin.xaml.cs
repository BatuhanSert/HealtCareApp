using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HealtCareApp
{
    public partial class EfeLogin : ContentPage
    {
        public EfeLogin()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Registration());
        }
    }
}
