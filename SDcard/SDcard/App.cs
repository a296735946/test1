﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SDcard
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //var content = new ContentPage
            //{
            //    Title = "SDcard",
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            //MainPage = new NavigationPage(content);


            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Green,
                BarTextColor = Color.Yellow,

            };
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
