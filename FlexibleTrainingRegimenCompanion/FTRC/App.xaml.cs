using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FTRC
{
    public partial class App : Application
    {
        public string DBPath { get; }

        public App(string dbPath) : this()
        {
            DBPath = dbPath;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainMenuView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
