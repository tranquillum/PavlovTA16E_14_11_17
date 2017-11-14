using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Login
{
    
    [Activity(Label = "NameAdd")]
    public class NameAdd : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NameAdd);
            var button = FindViewById<Button>(Resource.Id.List);         
            button.Click += Button_Click;
            var button2 = FindViewById<Button>(Resource.Id.Add);
            button2.Click += Button2_Click;
            // Create your application here
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(NameList));
            StartActivity(intent);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}