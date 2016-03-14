
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
	[Activity (Label = "InfoCard")]			
	public class InfoCard : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			SetContentView(Resource.Layout.InfoCard);

			FindViewById<TextView>(Resource.Id.infoCardLabel).Text = "American Express ****9274";
			FindViewById<TextView>(Resource.Id.infoCardType).Text = "American Express";
			FindViewById<TextView>(Resource.Id.infoNameOnCard).Text = "David Maxwell";
			FindViewById<TextView>(Resource.Id.infoCardNumber).Text = "0123 4567 8901 9274";
			FindViewById<TextView>(Resource.Id.infoExpirationDate).Text = "09/2016";
			FindViewById<TextView>(Resource.Id.infoCcvCode).Text = "012";
			FindViewById<TextView>(Resource.Id.infoBillingAddress).Text = "2940 eonis Blvd";
			FindViewById<TextView>(Resource.Id.infoBillingAddressZipCode).Text = "90058";

			var editCard = FindViewById<Button>(Resource.Id.bEdit);

			editCard.Click += (object sender, EventArgs e) => {
				StartActivity (typeof(EditCard));
			};
		}
	}
}

