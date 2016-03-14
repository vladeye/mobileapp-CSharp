
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
	[Activity (Label = "PusNotification")]			
	public class PusNotification : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			var items = new List<String>();
			items.Add("Beep");
			items.Add("Beep + Vibrate");
			items.Add("Off");
			
			this.ListAdapter = new StringList_Adapter(this, items);

		}
	}
}

