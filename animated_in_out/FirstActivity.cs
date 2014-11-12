using Android.App;
using Android.OS;
using Android.Widget;

namespace animated_in_out
{
    [Activity(Label = "FirstActivity", MainLauncher = true, Icon = "@drawable/icon")]			
    public class FirstActivity : MainActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.First);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "First activity";

            btnNext.Click += delegate
            {
                StartActivity(typeof(SecondActivity));
            };
        }
    }
}

