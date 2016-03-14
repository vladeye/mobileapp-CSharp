
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
	[Activity (Label = "ShoppingAssistant")]			
	public class ShoppingAssistant : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// build the option list
			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.Bookmark, "Bookmarks", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.Memberships, "Membership Cards", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.Business, "Businesses", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.Coupons, "Coupons", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.Catalogs, "Catalogs", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.RemoteProducts, "Remote Products", typeof(Bookmarks)));

			this.ListAdapter = new ImageList_Adapter(this, items);
		}

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var b = ((ImageList_Adapter)this.ListAdapter).GetBaseItemList (position);
			this.StartActivity(new Intent(this, b.ItemType));
		}
	}
}

