
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
	[Activity (Label = "Bookmarks")]			
	public class Bookmarks : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// build the option list
			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.BkBusiness, "Bookmarked Businesses", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.BkCoupons, "Bookmarked Coupons", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.BkCatalogs, "Bookmarked Catalogs", typeof(Bookmarks)));
			items.Add(new BaseItemList(Resource.Drawable.BkProducts, "Bookmarked Products", typeof(Bookmarks)));

			this.ListAdapter = new ImageList_Adapter(this, items);
		}
	}
}

