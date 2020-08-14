using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lottie.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MA.Views
{
    public partial class RegOrLogin : ContentPage
    {
        public RegOrLogin()
        {
            InitializeComponent();
            
        }

        public async void GetStarted_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

    }
}
