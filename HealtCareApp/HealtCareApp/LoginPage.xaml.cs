using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HealtCareApp.Tables;
using System.Diagnostics;
using Plugin.SharedTransitions;

namespace HealtCareApp

{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(string username, string password)
        {
            
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            entryUsername.Text = username;
            entryPassword.Text = password;

        }

        async void btnLogin_Clicked(System.Object sender, System.EventArgs e)
        {

            if(entryUsername.Text == "admin" && entryPassword.Text == "1234")
            {
                App.Current.MainPage = new SharedTransitionNavigationPage(new MainPage());
            }
            else
            {
                var result = await this.DisplayAlert("Error", "Wrong username or password! Do you want to register?", "Yes", "Cancel");
                if (result)
                {
                    App.Current.MainPage = new NavigationPage(new Registration());
                }
            }
            //var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDatabase.db");
            //var db = new SQLiteConnection(dbpath);

            //var connection = new SQLiteAsyncConnection(dbpath);
            ////await connection.CreateTableAsync<RegUserTable>();


            ////var existTable = db.Query<RegUserTable>("SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = 'RegUserTable'");


            ////Debug.WriteLine(existTable);

            //var loginQuery = db.Table<RegUserTable>().Where(u => u.Username.Equals(entryUsername.Text) && u.Password.Equals(entryPassword.Text)).FirstOrDefault();

            //if (loginQuery != null)
            //{
            //    //App.Current.MainPage = new NavigationPage(new WelcomePage(entryUsername.Text));
            //}
            //else
            //{
            //    Device.BeginInvokeOnMainThread(async () =>
            //    {
            //        var result = await this.DisplayAlert("Error", "Wrong username or password! Dou you want to register?", "Yes", "Cancel");

            //        if (result)
            //        {
            //            App.Current.MainPage = new NavigationPage(new Registration());
            //        }
            //        else
            //        {
            //            await Navigation.PushAsync(new LoginPage("", ""));
            //        }
            //    });
            //}
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Registration());
            //Device.BeginInvokeOnMainThread(async () =>
            //{
            //   await Navigation.PushAsync(new Registration());
            //});
        }

    }
}
