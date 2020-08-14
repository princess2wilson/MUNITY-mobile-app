using MA.Tables;
using MA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MA
{
    public partial class App : Application
    {
        public static bool accessability;
        public static string current_name;
        public static string current_username;
        public static string current_Email;
        public static string current_password;
        public static string current_description;


        public static string current_post_content;
        public static DateTime current_post_date;
        public static string current_post_title;
        public static string current_post_author;
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new RegOrLogin());
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
