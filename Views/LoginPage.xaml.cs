using MA.Tables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        static RegUserTable current_user = new RegUserTable();
        public LoginPage()
        {

            InitializeComponent();
            //To do
            //1.Triggers
            //2.email validation and password
            //3.animation to home page??
            //current_user.UserName = EntryUser.Text;
            //current_user.Password = EntryPassword.Text;

        }

        public async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

        public async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new tabbedpage());

        }
    }
}
