using System;
using System.Collections.Generic;
using System.IO;
using MA.Views;
using MA.Tables;
using SQLite;
using Xamarin.Forms;
using System.Text.RegularExpressions;
namespace MA.Views
{
    public partial class RegisterPage : ContentPage
    {
        Label lblMessage;
        public RegisterPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }
}


