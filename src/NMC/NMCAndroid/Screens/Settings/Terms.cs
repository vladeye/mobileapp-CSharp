
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

namespace NMCAndroid
{
	[Activity (Label = "Terms")]			
	public class Terms : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.SwitchSettingsText);
			var message = FindViewById<TextView>(Resource.Id.tMessage);
			message.Text = "String to Terms";
		}
	}
}

