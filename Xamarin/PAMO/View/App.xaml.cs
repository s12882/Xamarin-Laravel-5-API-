using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PAMO
{
	public partial class App : Application
    {
        public static WeatherManager WeatherManager { get; private set; }
        public static UserManager UserManager { get; private set; }

        static SQLiteManager database;
        public App ()
		{
            InitializeComponent();
            MainPage = new NavigationPage(new PAMO.LoginPage());
            WeatherManager = new WeatherManager(new RestService());
            UserManager = new UserManager(new RestService(), new StorageService());
           
        }

        public static SQLiteManager Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteManager();
                }
                return database;
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
    }
}
