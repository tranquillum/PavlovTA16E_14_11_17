using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;
using System.Runtime.Remoting.Contexts;
using System;
using Android.Content;

namespace Login
{
    [Activity(Label = "Login", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText username;
        EditText password;
        TextView OkOrNot;
        private bool LogOK = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            username = FindViewById<EditText>(Resource.Id.User);
            password = FindViewById<EditText>(Resource.Id.Password);
            OkOrNot = FindViewById<TextView>(Resource.Id.Logincontroll);

            var button = FindViewById<Button>(Resource.Id.Login);
            button.Click += Button_Click;
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            if (username.Text == "1" && password.Text == "1")
            {
                OkOrNot.Text = "Name and password OK";
                LogOK = true;
                var intent = new Intent(this, typeof(NameAdd));              
                StartActivity(intent);
            }
            else
            {
                OkOrNot.Text = "Name and password false";
                LogOK = false;
            }
            
        }

        
    }
}

