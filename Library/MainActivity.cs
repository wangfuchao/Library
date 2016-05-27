﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Library
{
    [Activity(Label = "Library", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button register = FindViewById<Button>(Resource.Id.btnRegister);

            register.Click += delegate
            {
                Intent ActRegister = new Intent(this, typeof(Register));
                StartActivity(ActRegister);
            };
        }
    }
}
//gitTest1111

