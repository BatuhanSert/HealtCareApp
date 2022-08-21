using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using SQLite;
using HealtCareApp.Tables;
using System.Diagnostics;

namespace HealtCareApp
{
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        public void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryUsername.Text)
                || string.IsNullOrWhiteSpace(entryPassword.Text)
                || string.IsNullOrWhiteSpace(entryPasswordValidation.Text)
                || string.IsNullOrWhiteSpace(entryName.Text)
                || string.IsNullOrWhiteSpace(entrySurname.Text)
                || !(checkBox.IsChecked))
            {

                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Please do not leave blank space!", "Yes", "No");
                });
            }
            else
            {
                if (entryPassword.Text != entryPasswordValidation.Text)
                {

                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await this.DisplayAlert("Error", "Passwords doesnt match!!", "Yes", "No");

                        //if (result)
                        //{
                        //    await Navigation.PushAsync(new Registration());
                        //}
                    });
                }
                else
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                                await this.DisplayAlert("Congratulation", "User Successfuly Register!", "Yes");
                                await Navigation.PushAsync(new LoginPage(entryUsername.Text, entryPassword.Text));

                    });
                }
            }
            //else
            //{
            //    int weight;
            //    var widthIsNumeric = int.TryParse(entryWeight.Text, out weight);
            //    int height;
            //    var heightIsNumeric = int.TryParse(entryHeight.Text, out height);
            //    Debug.WriteLine(height);
            //    Debug.WriteLine(weight);
            //    if(widthIsNumeric && heightIsNumeric && height > 100 && 270 >= height && weight > 0)
            //    {
            //        var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDatabase.db");
            //        var db = new SQLiteConnection(dbpath);//SQLiteConnection(dbpath);
            //        db.CreateTable<RegUserTable>();

            //        var item = new RegUserTable()
            //        {
            //            Username = entryUsername.Text,
            //            Password = entryPassword.Text,
            //            Dob = entryDob.Text,
            //            Weight = weight,
            //            Height = height
            //        };

            //        db.Insert(item);
            //        Device.BeginInvokeOnMainThread(async () =>
            //        {
            //            //var result =
            //            await this.DisplayAlert("Congratulation", "User Successfuly Register!", "Yes");

            //            //if (result)
            //            //{
            //                await Navigation.PushAsync(new LoginPage(entryUsername.Text,entryPassword.Text));
            //            //}
            //        });
            //    }
            //    else
            //    {
            //        Device.BeginInvokeOnMainThread(async () =>
            //        {
            //            var result = await this.DisplayAlert("Error", "Please enter a correct numerical value for weight and height", "Yes", "No");

            //            if (result)
            //            {
            //                await Navigation.PushAsync(new Registration());
            //            }
            //        });
            //    }
            // }

        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new LoginPage("",""));
            //App.Current.MainPage = new NavigationPage(new EfeLogin());
            //await Navigation.PushAsync(new LoginPage("",""));
        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            if (entryPassword.IsPassword)
            {
                entryPassword.IsPassword = false;
            }
            else
            {
                entryPassword.IsPassword = true;
            }
        }
    }
}
