
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace FragmentComponent.Droid.Fragments
{
    public class FirstFragment : Fragment
    {


        private ICountButtonTapped countButtonTapped;
        
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.first_fragment, container, false);

            Button buttonCount = (Android.Widget.Button)view.FindViewById(Resource.Id.counterButton);
            buttonCount.Click += ButtonCount_Click;
            return view;
        }

        void ButtonCount_Click(object sender, EventArgs e)
        {
            if(null != countButtonTapped){
                countButtonTapped.OnCountButtonTapped();
            }else{
                // Make Log
            }
        }


        public void SetDelegate(ICountButtonTapped countButtonTapped){
            this.countButtonTapped = countButtonTapped;
        }

    }

    public interface ICountButtonTapped{
        void OnCountButtonTapped();
    }
}
