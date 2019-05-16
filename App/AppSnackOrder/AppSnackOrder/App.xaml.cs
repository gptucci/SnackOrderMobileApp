using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSnackOrder
{
    public partial class App : Application
    {

        public static List<string> ListaPanini = new List<string>();

        public App()
        {
            InitializeComponent();

            ListaPanini.Add("Panino con prosciutto cotto");
            ListaPanini.Add("Panino con prosciutto crudo");
            ListaPanini.Add("Panino con tonno");

            MainPage = new MainPage();
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
