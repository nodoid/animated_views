using Android.App;
using Android.OS;
using Android.Widget;

namespace animated_in_out
{
    [Activity(Label = "ThirdActivity")]			
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.First);
            var btnNext = FindViewById<Button>(Resource.Id.btnNext);
            var txtTitle = FindViewById<TextView>(Resource.Id.textTitle);
            txtTitle.Text = "Third activity";
            btnNext.Text = "Back";
            btnNext.Click += delegate
            {
                Finish();
            };
        }
    }
}

