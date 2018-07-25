﻿using Android.App;
using Android.Content;
using Android.Runtime;
using CityMapXamarin.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using System;

namespace CityMapXamarin.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        public Setup()
        {

        }

        public Setup(Context context) : base()
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}