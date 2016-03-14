
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
	[Activity (Label = "Language")]			
	public class Language : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			var items = new List<String>();
			items.Add("English");
			items.Add("Español");
			items.Add("Nederlands");
			items.Add("Francais");
			items.Add("Deutsch");
			items.Add("Italiano");
			items.Add("Portugues");
			items.Add("Pyccko");

			this.ListAdapter = new StringList_Adapter(this, items);


		}
	}
}

