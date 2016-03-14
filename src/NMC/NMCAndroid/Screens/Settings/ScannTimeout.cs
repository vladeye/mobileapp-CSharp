
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
	[Activity (Label = "ScannTimeout")]			
	public class ScannTimeout : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var items = new List<String>();
			items.Add("1Second");
			items.Add("2Seconds");
			items.Add("3Seconds");
			items.Add("4Seconds");
			items.Add("5Seconds");
			items.Add("6Seconds");
			items.Add("7Seconds");
			items.Add("8Seconds");
			items.Add("9Seconds");
			items.Add("10Seconds");
			
			this.ListAdapter = new StringList_Adapter(this, items);
			
		}
	}
}

