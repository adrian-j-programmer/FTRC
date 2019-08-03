using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace FTRC.Droid
{
    [Activity(Label = "Flexible Training Regimen Companion", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(GetDBPath()));
        }

        private string GetDBPath()
        {
            string dbName = "ftrc_db.sqlite";
            string dbDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(dbDirectory, dbName);
        }
    }
}