
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
	[Activity (Label = "AddNewAddress")]			
	public class AddNewAddress : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.AddNewAddress);

			var confirmNewAddress = FindViewById<Button>(Resource.Id.bAddNewAddressConfirmar);
			confirmNewAddress.Click += (object sender, EventArgs e) => {
				StartActivity (typeof(Addresses));
			};
		}
	}
}

