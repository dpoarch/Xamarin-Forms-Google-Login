﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleLogin.Views;
using Xamarin.Forms;

namespace GoogleLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainCsPage());
            //MainPage = new GoogleLogin.MainPage();
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
