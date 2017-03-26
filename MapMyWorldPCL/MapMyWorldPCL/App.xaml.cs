using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapMyWorldPCL.Data;

using Xamarin.Forms;

namespace MapMyWorldPCL
{
    public partial class App : Application
    {
        static dbForm database;
        public App()
        {
            InitializeComponent();

            MainPage = new MapMyWorldPCL.View.Page16MyDreamGoals();
        }

        public static dbForm Database
        {
            get
            {
                if (database == null)
                {
                    database = new dbForm(DependencyService.Get<IFileHelper>().GetLocalFilePath("FormSQLite.db3"));
                }
                return database;
            }
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
