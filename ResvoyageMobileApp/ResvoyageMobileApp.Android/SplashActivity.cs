﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace ResvoyageMobileApp.Droid
{
    [Activity(Label = "Farelovers", Theme = "@style/MyTheme.Splash", Icon = "@drawable/logoIcon", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            var intent = new Intent(this, typeof(MainActivity));
            if (Intent.Extras != null)
            {
                intent.PutExtras(Intent.Extras);
            }
            StartActivity(intent);
        }
    }
}