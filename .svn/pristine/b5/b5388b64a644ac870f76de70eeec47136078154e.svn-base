
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
	[Activity (Label = "Addresses")]			
	public class Addresses : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.work, "Home01", typeof(Addresses)));
			items.Add(new BaseItemList(Resource.Drawable.work, "Work", typeof(Addresses)));
			items.Add(new BaseItemList(Resource.Drawable.Cvacia, "Add New Address ...", typeof(AddNewAddress)));
			
			this.ListAdapter = new ImageList_Adapter(this, items);
		}
		
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var b = ((ImageList_Adapter)this.ListAdapter).GetBaseItemList (position);
			this.StartActivity(new Intent(this, b.ItemType));
		}
	}
}

