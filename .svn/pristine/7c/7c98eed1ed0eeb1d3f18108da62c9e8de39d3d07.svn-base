
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
	[Activity (Label = "UserInfo")]			
	public class UserInfo : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//Create your application here
			SetContentView(Resource.Layout.UserInfo);
			var userInforConfirm = FindViewById<Button>(Resource.Id.bUserInfoConfirmar);
			userInforConfirm.Click += (object sender, EventArgs e) => {
				StartActivity (typeof(Settings));
			};
		}
	}
}

