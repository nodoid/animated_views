using Android.App;
using Android.OS;
using Android.Widget;

namespace animated_in_out
{
    [Activity(Label = "SecondActivity")]			
    public class SecondActivity : MainActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Second);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var btnBack = FindViewById<Button>(Resource.Id.btnBack);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "Second activity";

            btnNext.Click += delegate
            {
                StartActivity(typeof(ThirdActivity));
            };

            btnBack.Click += delegate
            {
                Finish();
            };
        }
    }
}

