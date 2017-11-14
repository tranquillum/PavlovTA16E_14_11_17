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
    [Activity(Label = "NameList")]
    public class NameList : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NameList);

            // Create your application here
        }
        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //var clickedPost = posts[e.Position];

            //var intent = new Intent(this, typeof(NameAtivity));
            //intent.PutExtra("Title", clickedPost.Title);
            

            //StartActivity(intent);

        }
    }
}