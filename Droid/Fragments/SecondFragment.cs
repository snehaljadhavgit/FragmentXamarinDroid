
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace FragmentComponent.Droid.Fragments
{
    
    public class SecondFragment : Fragment
    {

        static int count = 0;

        TextView textView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.second_fragment, container, false);
            textView = (Android.Widget.TextView)view.FindViewById(Resource.Id.resultTextView);
            return view;
        }

        public void CountButtonPressed(){
            try
            {

                    ++count;
                    textView.Text = "Count: " + count;

                    if (count > 10)
                    {

                        textView = null;
                        textView.Text = "Nullable string";
                    }
                Analytics.TrackEvent(count.ToString());
               // Analytics.TrackEvent("Line 2 count button");
               }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }

        }
    }
}
