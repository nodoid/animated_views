using Android.App;
using Android.OS;

namespace animated_in_out
{
    [Activity]
    public class MainActivity : Activity
    {
        int count = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            count = 1;

            if (bundle == null)
                OverridePendingTransition(Resource.Animation.slide_in_left, Resource.Animation.slide_in_right);
            else
                count = 2;
        }

        protected override void OnStart()
        {
            base.OnStart();
            if (count > 1)
                OverridePendingTransition(Resource.Animation.slide_in_right, Resource.Animation.slide_in_left);
            else if (count == 1)
                count++;
        }
    }
}


